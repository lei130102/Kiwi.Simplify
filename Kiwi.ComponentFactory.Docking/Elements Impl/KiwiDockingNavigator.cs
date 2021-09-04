﻿using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Provides docking functionality by attaching to an existing KiwiDockableNavigator
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiDockingNavigator : DockingElementClosedCollection
    {
        #region Instance Fields
        private string _storeName;
        private KiwiDockableNavigator _navigator;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiDockingNavigator class.
        /// </summary>
        /// <param name="name">Initial name of the element.</param>
        public KiwiDockingNavigator(string name)
            : this(name, "Workspace", new KiwiDockableNavigator())
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiDockingNavigator class.
        /// </summary>
        /// <param name="name">Initial name of the element.</param>
        /// <param name="storeName">Name to use for storage pages.</param>
        /// <param name="navigator">Reference to navigator to manage.</param>
        public KiwiDockingNavigator(string name,
                                       string storeName,
                                       KiwiDockableNavigator navigator)
            : base(name)
        {
            if (navigator == null)
                throw new ArgumentNullException("navigator");

            _storeName = storeName;
            _navigator = navigator;

            DockableNavigatorControl.Disposed += new EventHandler(OnDockableNavigatorDisposed);
            DockableNavigatorControl.CellPageInserting += new EventHandler<KiwiPageEventArgs>(OnDockableNavigatorPageInserting);
            DockableNavigatorControl.BeforePageDrag += new EventHandler<PageDragCancelEventArgs>(OnDockableNavigatorBeforePageDrag);
            DockableNavigatorControl.PageDrop += new EventHandler<PageDropEventArgs>(OnDockableNavigatorPageDrop);
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the control this element is managing.
        /// </summary>
        public KiwiDockableNavigator DockableNavigatorControl
        {
            get { return _navigator; }
        }

        /// <summary>
        /// Gets and sets access to the parent docking element.
        /// </summary>
        public override IDockingElement Parent
        {
            set
            {
                // Let base class perform standard processing
                base.Parent = value;

                // Generate event so the any dockable navigator customization can be performed.
                KiwiDockingManager dockingManager = DockingManager;
                if (dockingManager != null)
                {
                    DockableNavigatorEventArgs args = new DockableNavigatorEventArgs(DockableNavigatorControl, this);
                    dockingManager.RaiseDockableNavigatorAdded(args);
                }
            }
        }

        /// <summary>
        /// Add a KiwiPage to the navigator.
        /// </summary>
        /// <param name="page">KiwiPage to be added.</param>
        public void Append(KiwiPage page)
        {
            // Use existing array adding method to prevent duplication of code
            Append(new KiwiPage[] { page });
        }

        /// <summary>
        /// Add a KiwiPage array to the navigator.
        /// </summary>
        /// <param name="pages">Array of KiwiPage instances to be added.</param>
        public void Append(KiwiPage[] pages)
        {
            // Demand that pages are not already present
            DemandPagesNotBePresent(pages);

            if (pages != null)
                DockableNavigatorControl.Pages.AddRange(pages);
        }

        /// <summary>
        /// Show all display elements of the provided page.
        /// </summary>
        /// <param name="page">Reference to page that should be shown.</param>
        public void ShowPage(KiwiPage page)
        {
            // Cannot show a null reference
            if (page == null)
                throw new ArgumentNullException("page");

            ShowPages(new string[] { page.UniqueName });
        }

        /// <summary>
        /// Show all display elements of the provided page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page that should be shown.</param>
        public void ShowPage(string uniqueName)
        {
            // Cannot show a null reference
            if (uniqueName == null)
                throw new ArgumentNullException("uniqueName");

            ShowPages(new string[] { uniqueName });
        }

        /// <summary>
        /// Show all display elements of the provided pages.
        /// </summary>
        /// <param name="pages">Array of references to pages that should be shown.</param>
        public void ShowPages(KiwiPage[] pages)
        {
            // Cannot show a null reference
            if (pages == null)
                throw new ArgumentNullException("pages");

            if (pages.Length > 0)
            {
                string[] uniqueNames = new string[pages.Length];
                for (int i = 0; i < uniqueNames.Length; i++)
                {
                    // Cannot show a null page reference
                    if (pages[i] == null)
                        throw new ArgumentException("pages array contains a null page reference");

                    uniqueNames[i] = pages[i].UniqueName;
                }

                ShowPages(uniqueNames);
            }
        }

        /// <summary>
        /// Show all display elements of the provided pages.
        /// </summary>
        /// <param name="uniqueNames">Array of unique names of the pages that should be shown.</param>
        public void ShowPages(string[] uniqueNames)
        {
            // Cannot show a null reference
            if (uniqueNames == null)
                throw new ArgumentNullException("uniqueNames");

            if (uniqueNames.Length > 0)
            {
                // Cannot show a null or zero length unique name
                foreach (string uniqueName in uniqueNames)
                {
                    if (uniqueName == null)
                        throw new ArgumentNullException("uniqueNames array contains a null string reference");

                    if (uniqueName.Length == 0)
                        throw new ArgumentException("uniqueNames array contains a zero length string");
                }

                using (DockingMultiUpdate update = new DockingMultiUpdate(this))
                    base.PropogateAction(DockingPropogateAction.ShowPages, uniqueNames);
            }
        }

        /// <summary>
        /// Show all display elements of all pages.
        /// </summary>
        public void ShowAllPages()
        {
            using (DockingMultiUpdate update = new DockingMultiUpdate(this))
                base.PropogateAction(DockingPropogateAction.ShowAllPages, (string[])null);
        }

        /// <summary>
        /// Hide all display elements of the provided page.
        /// </summary>
        /// <param name="page">Reference to page that should be hidden.</param>
        public void HidePage(KiwiPage page)
        {
            // Cannot hide a null reference
            if (page == null)
                throw new ArgumentNullException("page");

            HidePages(new string[] { page.UniqueName });
        }

        /// <summary>
        /// Hide all display elements of the provided page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page that should be hidden.</param>
        public void HidePage(string uniqueName)
        {
            // Cannot hide a null reference
            if (uniqueName == null)
                throw new ArgumentNullException("uniqueName");

            if (uniqueName.Length > 0)
                HidePages(new string[] { uniqueName });
        }

        /// <summary>
        /// Hide all display elements of the provided pages.
        /// </summary>
        /// <param name="pages">Array of references to pages that should be hidden.</param>
        public void HidePages(KiwiPage[] pages)
        {
            // Cannot hide a null reference
            if (pages == null)
                throw new ArgumentNullException("pages");

            if (pages.Length > 0)
            {
                // Cannot hide a null page reference
                string[] uniqueNames = new string[pages.Length];
                for (int i = 0; i < uniqueNames.Length; i++)
                {
                    // Cannot show a null page reference
                    if (pages[i] == null)
                        throw new ArgumentException("pages array contains a null page reference");

                    uniqueNames[i] = pages[i].UniqueName;
                }

                HidePages(uniqueNames);
            }
        }

        /// <summary>
        /// Hide all display elements of the provided pages.
        /// </summary>
        /// <param name="uniqueNames">Array of unique names of the pages that should be hidden.</param>
        public void HidePages(string[] uniqueNames)
        {
            // Cannot hide a null reference
            if (uniqueNames == null)
                throw new ArgumentNullException("uniqueNames");

            if (uniqueNames.Length > 0)
            {
                // Cannot hide a null or zero length unique name
                foreach (string uniqueName in uniqueNames)
                {
                    if (uniqueName == null)
                        throw new ArgumentNullException("uniqueNames array contains a null string reference");

                    if (uniqueName.Length == 0)
                        throw new ArgumentException("uniqueNames array contains a zero length string");
                }

                using (DockingMultiUpdate update = new DockingMultiUpdate(this))
                    base.PropogateAction(DockingPropogateAction.HidePages, uniqueNames);
            }
        }

        /// <summary>
        /// Hide all display elements of all pages.
        /// </summary>
        public void HideAllPages()
        {
            using (DockingMultiUpdate update = new DockingMultiUpdate(this))
                base.PropogateAction(DockingPropogateAction.HideAllPages, (string[])null);
        }

        /// <summary>
        /// Remove the named page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page that should be removed.</param>
        /// <param name="disposePage">Should the page be disposed when removed.</param>
        public void RemovePage(string uniqueName, bool disposePage)
        {
            // Cannot remove a null reference
            if (uniqueName == null)
                throw new ArgumentNullException("uniqueName");

            // Unique names cannot be zero length
            if (uniqueName.Length == 0)
                throw new ArgumentException("uniqueName cannot be zero length");

            RemovePages(new string[] { uniqueName }, disposePage);
        }

        /// <summary>
        /// Remove the referenced pages.
        /// </summary>
        /// <param name="pages">Array of references to pages that should be removed.</param>
        /// <param name="disposePage">Should the page be disposed when removed.</param>
        public void RemovePages(KiwiPage[] pages, bool disposePage)
        {
            // Cannot remove a null reference
            if (pages == null)
                throw new ArgumentNullException("pages");

            if (pages.Length > 0)
            {
                // Cannot remove a null page reference
                string[] uniqueNames = new string[pages.Length];
                for (int i = 0; i < uniqueNames.Length; i++)
                {
                    // Cannot show a null page reference
                    if (pages[i] == null)
                        throw new ArgumentException("pages array contains a null page reference");

                    uniqueNames[i] = pages[i].UniqueName;
                }

                RemovePages(uniqueNames, disposePage);
            }
        }

        /// <summary>
        /// Remove the named pages.
        /// </summary>
        /// <param name="uniqueNames">Array of unique names of the pages that should be removed.</param>
        /// <param name="disposePage">Should the page be disposed when removed.</param>
        public void RemovePages(string[] uniqueNames, bool disposePage)
        {
            // Cannot remove a null reference
            if (uniqueNames == null)
                throw new ArgumentNullException("uniqueNames");

            if (uniqueNames.Length > 0)
            {
                // Cannot remove a null or zero length unique name
                foreach (string uniqueName in uniqueNames)
                {
                    if (uniqueName == null)
                        throw new ArgumentNullException("uniqueNames array contains a null string reference");

                    if (uniqueName.Length == 0)
                        throw new ArgumentException("uniqueNames array contains a zero length string");
                }

                // Remove page details from all parts of the hierarchy
                using (DockingMultiUpdate update = new DockingMultiUpdate(this))
                    base.PropogateAction(disposePage ? DockingPropogateAction.RemoveAndDisposePages : DockingPropogateAction.RemovePages, uniqueNames);
            }
        }

        /// <summary>
        /// Remove all pages.
        /// </summary>
        /// <param name="disposePage">Should the page be disposed when removed.</param>
        public void RemoveAllPages(bool disposePage)
        {
            // Remove all details about all pages from all parts of the hierarchy
            using (DockingMultiUpdate update = new DockingMultiUpdate(this))
                base.PropogateAction(disposePage ? DockingPropogateAction.RemoveAndDisposeAllPages : DockingPropogateAction.RemoveAllPages, (string[])null);
        }

        /// <summary>
        /// Propogates an action request down the hierarchy of docking elements.
        /// </summary>
        /// <param name="action">Action that is requested to be performed.</param>
        /// <param name="uniqueNames">Array of unique names of the pages the action relates to.</param>
        public override void PropogateAction(DockingPropogateAction action, string[] uniqueNames)
        {
            switch (action)
            {
                case DockingPropogateAction.Loading:
                    // Remove all pages including store pages
                    DockableNavigatorControl.Pages.Clear();
                    return;
                case DockingPropogateAction.ShowAllPages:
                case DockingPropogateAction.HideAllPages:
                case DockingPropogateAction.RemoveAllPages:
                case DockingPropogateAction.RemoveAndDisposeAllPages:
                    // Ignore some global actions
                    return;
                case DockingPropogateAction.StorePages:
                    foreach (string uniqueName in uniqueNames)
                    {
                        // Swap pages that are not placeholders to become placeholders
                        KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
                        if ((page != null) && !(page is KiwiStorePage))
                        {
                            // Replace the existing page with a placeholder that has the same unique name
                            KiwiStorePage placeholder = new KiwiStorePage(uniqueName, _storeName);
                            DockableNavigatorControl.Pages.Insert(DockableNavigatorControl.Pages.IndexOf(page), placeholder);
                            DockableNavigatorControl.Pages.Remove(page);
                        }
                    }
                    break;
                case DockingPropogateAction.StoreAllPages:
                    {
                        // Process each page inside the cell
                        for (int i = DockableNavigatorControl.Pages.Count - 1; i >= 0; i--)
                        {
                            // Swap pages that are not placeholders to become placeholders
                            KiwiPage page = DockableNavigatorControl.Pages[i];
                            if ((page != null) && !(page is KiwiStorePage))
                            {
                                // Replace the existing page with a placeholder that has the same unique name
                                KiwiStorePage placeholder = new KiwiStorePage(page.UniqueName, _storeName);
                                DockableNavigatorControl.Pages.Insert(DockableNavigatorControl.Pages.IndexOf(page), placeholder);
                                DockableNavigatorControl.Pages.Remove(page);
                            }
                        }
                    }
                    break;
                case DockingPropogateAction.ClearFillerStoredPages:
                case DockingPropogateAction.ClearStoredPages:
                    foreach (string uniqueName in uniqueNames)
                    {
                        // Only remove a matching unique name if it is a placeholder page
                        KiwiPage removePage = DockableNavigatorControl.Pages[uniqueName];
                        if ((removePage != null) && (removePage is KiwiStorePage))
                            DockableNavigatorControl.Pages.Remove(removePage);
                    }
                    break;
                case DockingPropogateAction.ClearAllStoredPages:
                    {
                        // Process each page inside the cell
                        for (int i = DockableNavigatorControl.Pages.Count - 1; i >= 0; i--)
                        {
                            // Remove all placeholders
                            KiwiPage page = DockableNavigatorControl.Pages[i];
                            if ((page != null) && (page is KiwiStorePage))
                                DockableNavigatorControl.Pages.Remove(page);
                        }
                    }
                    break;
                case DockingPropogateAction.DebugOutput:
                    Console.WriteLine(GetType().ToString());
                    DockableNavigatorControl.DebugOutput();
                    break;
            }

            // Let base class perform standard processing
            base.PropogateAction(action, uniqueNames);
        }

        /// <summary>
        /// Propogates a boolean state request down the hierarchy of docking elements.
        /// </summary>
        /// <param name="state">Boolean state that is requested to be recovered.</param>
        /// <param name="uniqueName">Unique name of the page the request relates to.</param>
        /// <returns>True/False if state is known; otherwise null indicating no information available.</returns>
        public override bool? PropogateBoolState(DockingPropogateBoolState state, string uniqueName)
        {
            switch (state)
            {
                case DockingPropogateBoolState.ContainsPage:
                    {
                        // Return the definitive answer 'true' if the control contains the named page
                        KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
                        if ((page != null) && !(page is KiwiStorePage))
                            return true;
                    }
                    break;
                case DockingPropogateBoolState.ContainsStorePage:
                    {
                        // Return definitive answer 'true' if the group controls contains a store page for the unique name.
                        KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
                        if ((page != null) && (page is KiwiStorePage))
                            return true;
                    }
                    break;
                case DockingPropogateBoolState.IsPageShowing:
                    {
                        // If we have the requested page then return the visible state of the page
                        KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
                        if ((page != null) && !(page is KiwiStorePage))
                            return page.LastVisibleSet;
                    }
                    break;
            }

            // Let base class perform standard processing
            return base.PropogateBoolState(state, uniqueName);
        }

        /// <summary>
        /// Propogates a page request down the hierarchy of docking elements.
        /// </summary>
        /// <param name="state">Request that should result in a page reference if found.</param>
        /// <param name="uniqueName">Unique name of the page the request relates to.</param>
        /// <returns>Reference to page that matches the request; otherwise null.</returns>
        public override KiwiPage PropogatePageState(DockingPropogatePageState state, string uniqueName)
        {
            switch (state)
            {
                case DockingPropogatePageState.PageForUniqueName:
                    {
                        // If we have the requested name page and it is not a placeholder then we have found it
                        KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
                        if ((page != null) && !(page is KiwiStorePage))
                            return page;
                    }
                    break;
            }

            // Let base class perform standard processing
            return base.PropogatePageState(state, uniqueName);
        }

        /// <summary>
        /// Propogates a page list request down the hierarchy of docking elements.
        /// </summary>
        /// <param name="state">Request that should result in pages collection being modified.</param>
        /// <param name="pages">Pages collection for modification by the docking elements.</param>
        public override void PropogatePageList(DockingPropogatePageList state, KiwiPageCollection pages)
        {
            switch (state)
            {
                case DockingPropogatePageList.All:
                case DockingPropogatePageList.Docked:
                case DockingPropogatePageList.Floating:
                case DockingPropogatePageList.Filler:
                    {
                        // If the request relevant to this space control?
                        if ((state == DockingPropogatePageList.All) || (state == DockingPropogatePageList.Filler))
                        {
                            // Process each page inside the navigator
                            for (int i = DockableNavigatorControl.Pages.Count - 1; i >= 0; i--)
                            {
                                // Only add real pages and not placeholders
                                KiwiPage page = DockableNavigatorControl.Pages[i];
                                if ((page != null) && !(page is KiwiStorePage))
                                    pages.Add(page);
                            }
                        }
                    }
                    break;
            }

            // Let base class perform standard processing
            base.PropogatePageList(state, pages);
        }

        /// <summary>
        /// Propogates a request for drag targets down the hierarchy of docking elements.
        /// </summary>
        /// <param name="floatingWindow">Reference to window being dragged.</param>
        /// <param name="dragData">Set of pages being dragged.</param>
        /// <param name="targets">Collection of drag targets.</param>
        public override void PropogateDragTargets(KiwiFloatingWindow floatingWindow,
                                                  PageDragEndData dragData,
                                                  DragTargetList targets)
        {
            // Create list of the pages that are allowed to be dropped into this navigator
            KiwiPageCollection pages = new KiwiPageCollection();
            foreach (KiwiPage page in dragData.Pages)
                if (page.AreFlagsSet(KiwiPageFlags.DockingAllowNavigator))
                    pages.Add(page);

            // Do we have any pages left for dragging?
            if (pages.Count > 0)
            {
                DragTargetList navigatorTargets = DockableNavigatorControl.GenerateDragTargets(new PageDragEndData(this, pages), KiwiPageFlags.DockingAllowNavigator);
                targets.AddRange(navigatorTargets.ToArray());
            }
        }

        /// <summary>
        /// Find the docking location of the named page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page.</param>
        /// <returns>Enumeration value indicating docking location.</returns>
        public override DockingLocation FindPageLocation(string uniqueName)
        {
            KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
            if ((page != null) && !(page is KiwiStorePage))
                return DockingLocation.Navigator;
            else
                return DockingLocation.None;
        }

        /// <summary>
        /// Find the docking element that contains the named page.
        /// </summary>
        /// <param name="uniqueName">Unique name of the page.</param>
        /// <returns>IDockingElement reference if page is found; otherwise null.</returns>
        public override IDockingElement FindPageElement(string uniqueName)
        {
            KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
            if ((page != null) && !(page is KiwiStorePage))
                return this;
            else
                return null;
        }

        /// <summary>
        /// Find the docking element that contains the location specific store page for the named page.
        /// </summary>
        /// <param name="location">Location to be searched.</param>
        /// <param name="uniqueName">Unique name of the page to be found.</param>
        /// <returns>IDockingElement reference if store page is found; otherwise null.</returns>
        public override IDockingElement FindStorePageElement(DockingLocation location, string uniqueName)
        {
            if (location == DockingLocation.Navigator)
            {
                KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
                if ((page != null) && (page is KiwiStorePage))
                    return this;
            }

            return null;
        }

        /// <summary>
        /// Find a navigator element by searching the hierarchy.
        /// </summary>
        /// <param name="uniqueName">Named page for which a suitable navigator element is required.</param>
        /// <returns>KiwiDockingNavigator reference if found; otherwise false.</returns>
        public override KiwiDockingNavigator FindDockingNavigator(string uniqueName)
        {
            return this;
        }

        /// <summary>
        /// Gets the number of visible pages.
        /// </summary>
        public int VisiblePages
        {
            get { return DockableNavigatorControl.Pages.VisibleCount; }
        }

        /// <summary>
        /// Ensure the provided page is selected within the cell that contains it.
        /// </summary>
        /// <param name="uniqueName">Unique name to be selected.</param>
        public void SelectPage(string uniqueName)
        {
            // Check that the pages collection contains the named paged
            KiwiPage page = DockableNavigatorControl.Pages[uniqueName];
            if (page != null)
                DockableNavigatorControl.SelectedPage = page;
        }

        /// <summary>
        /// Saves docking configuration information using a provider xml writer.
        /// </summary>
        /// <param name="xmlWriter">Xml writer object.</param>
        public override void SaveElementToXml(XmlWriter xmlWriter)
        {
            // Output navigator docking element
            xmlWriter.WriteStartElement(XmlElementName);
            xmlWriter.WriteAttributeString("N", Name);
            xmlWriter.WriteAttributeString("C", DockableNavigatorControl.Pages.Count.ToString());

            // Persist each child page in turn
            KiwiDockingManager dockingManager = DockingManager;
            foreach (KiwiPage page in DockableNavigatorControl.Pages)
            {
                // Are we allowed to save the page?
                if (page.AreFlagsSet(KiwiPageFlags.AllowConfigSave))
                {
                    xmlWriter.WriteStartElement("KP");
                    CommonHelper.TextToXmlAttribute(xmlWriter, "UN", page.UniqueName);
                    CommonHelper.TextToXmlAttribute(xmlWriter, "S", CommonHelper.BoolToString(page is KiwiStorePage));
                    CommonHelper.TextToXmlAttribute(xmlWriter, "V", CommonHelper.BoolToString(page.LastVisibleSet), "True");

                    // Give event handlers a chance to save custom data with the page
                    xmlWriter.WriteStartElement("CPD");
                    DockPageSavingEventArgs args = new DockPageSavingEventArgs(dockingManager, xmlWriter, page);
                    dockingManager.RaisePageSaving(args);
                    xmlWriter.WriteEndElement();

                    // Terminate the page element        
                    xmlWriter.WriteEndElement();
                }
            }

            // Output an xml for the contained workspace

            // Terminate the workspace element
            xmlWriter.WriteFullEndElement();
        }

        /// <summary>
        /// Loads docking configuration information using a provider xml reader.
        /// </summary>
        /// <param name="xmlReader">Xml reader object.</param>
        /// <param name="pages">Collection of available pages for adding.</param>
        public override void LoadElementFromXml(XmlReader xmlReader, KiwiPageCollection pages)
        {
            // Is it the expected xml element name?
            if (xmlReader.Name != XmlElementName)
                throw new ArgumentException("Element name '" + XmlElementName + "' was expected but found '" + xmlReader.Name + "' instead.");

            // Grab the element attributes
            string elementName = xmlReader.GetAttribute("N");
            string elementCount = xmlReader.GetAttribute("C");

            // Check the name matches up
            if (elementName != Name)
                throw new ArgumentException("Attribute 'N' value '" + Name + "' was expected but found '" + elementName + "' instead.");

            // Remove any existing pages in the navigator
            DockableNavigatorControl.Pages.Clear();

            // If there are children then load them
            int count = int.Parse(elementCount);
            if (count > 0)
            {
                KiwiDockingManager manager = DockingManager;
                for (int i = 0; i < count; i++)
                {
                    // Read past this element
                    if (!xmlReader.Read())
                        throw new ArgumentException("An element was expected but could not be read in.");

                    // Is it the expected xml element name?
                    if (xmlReader.Name != "KP")
                        throw new ArgumentException("Element name 'KP' was expected but found '" + xmlReader.Name + "' instead.");

                    // Get the unique name of the page
                    string uniqueName = CommonHelper.XmlAttributeToText(xmlReader, "UN");
                    bool boolStore = CommonHelper.StringToBool(CommonHelper.XmlAttributeToText(xmlReader, "S"));
                    bool boolVisible = CommonHelper.StringToBool(CommonHelper.XmlAttributeToText(xmlReader, "V", "True"));

                    KiwiPage page = null;

                    // If the entry is for just a placeholder...
                    if (boolStore)
                    {
                        // Recreate the requested store page and append
                        page = new KiwiStorePage(uniqueName, _storeName);
                        DockableNavigatorControl.Pages.Add(page);
                    }
                    else
                    {
                        // Can we find a provided page to match the incoming layout?
                        page = pages[uniqueName];
                        if (page == null)
                        {
                            // Generate event so developer can create and supply the page now
                            RecreateLoadingPageEventArgs args = new RecreateLoadingPageEventArgs(uniqueName);
                            manager.RaiseRecreateLoadingPage(args);

                            if (!args.Cancel && (args.Page != null))
                                page = args.Page;
                        }

                        if (page != null)
                        {
                            // Use the loaded visible state
                            page.Visible = boolVisible;

                            // Remove from provided collection as we can only add it once to the docking hierarchy
                            pages.Remove(page);

                            // Add into the navigator
                            DockableNavigatorControl.Pages.Add(page);
                        }
                    }

                    if (!xmlReader.Read())
                        throw new ArgumentException("An element was expected but could not be read in.");

                    if (xmlReader.Name != "CPD")
                        throw new ArgumentException("Expected 'CPD' element was not found");

                    bool finished = xmlReader.IsEmptyElement;

                    // Generate event so custom data can be loaded and/or the page to be added can be modified
                    DockPageLoadingEventArgs pageLoading = new DockPageLoadingEventArgs(manager, xmlReader, page);
                    manager.RaisePageLoading(pageLoading);

                    // Read everything until we get the end of custom data marker
                    while (!finished)
                    {
                        // Check it has the expected name
                        if (xmlReader.NodeType == XmlNodeType.EndElement)
                            finished = (xmlReader.Name == "CPD");

                        if (!finished)
                        {
                            if (!xmlReader.Read())
                                throw new ArgumentException("An element was expected but could not be read in.");
                        }
                    }

                    if (!xmlReader.Read())
                        throw new ArgumentException("An element was expected but could not be read in.");
                }
            }

            // Read past this element to the end element
            if (!xmlReader.Read())
                throw new ArgumentException("An element was expected but could not be read in.");
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets the xml element name to use when saving.
        /// </summary>
        protected override string XmlElementName
        {
            get { return "DN"; }
        }
        #endregion

        #region Implementation
        private void OnDockableNavigatorDisposed(object sender, EventArgs e)
        {
            // Unhook from events to prevent memory leaking
            DockableNavigatorControl.Disposed -= new EventHandler(OnDockableNavigatorDisposed);
            DockableNavigatorControl.CellPageInserting -= new EventHandler<KiwiPageEventArgs>(OnDockableNavigatorPageInserting);
            DockableNavigatorControl.BeforePageDrag -= new EventHandler<PageDragCancelEventArgs>(OnDockableNavigatorBeforePageDrag);
            DockableNavigatorControl.PageDrop -= new EventHandler<PageDropEventArgs>(OnDockableNavigatorPageDrop);

            // Generate event so the any dockable navigator customization can be reversed.
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                DockableNavigatorEventArgs args = new DockableNavigatorEventArgs(DockableNavigatorControl, this);
                dockingManager.RaiseDockableNavigatorRemoved(args);
            }
        }

        private void OnDockableNavigatorPageInserting(object sender, KiwiPageEventArgs e)
        {
            // Remove any store page for the unique name of this page being added. In either case of adding a store
            // page or a regular page we want to ensure there does not exist a store page for that same unique name.
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
                dockingManager.PropogateAction(DockingPropogateAction.ClearFillerStoredPages, new string[] { e.Item.UniqueName });
        }

        private void OnDockableNavigatorBeforePageDrag(object sender, PageDragCancelEventArgs e)
        {
            // Validate the list of names to those that are still present in the navigator
            List<KiwiPage> pages = new List<KiwiPage>();
            foreach (KiwiPage page in e.Pages)
                if (!(page is KiwiStorePage) && DockableNavigatorControl.Pages.Contains(page))
                    pages.Add(page);

            // Only need to start docking dragging if we have some valid pages
            if (pages.Count != 0)
            {
                // Ask the docking manager for a IDragPageNotify implementation to handle the dragging operation
                KiwiDockingManager dockingManager = DockingManager;
                if (dockingManager != null)
                    dockingManager.DoDragDrop(e.ScreenPoint, e.ElementOffset, e.Control, e.Pages);
            }

            // Always take over docking
            e.Cancel = true;
        }

        private void OnDockableNavigatorPageDrop(object sender, PageDropEventArgs e)
        {
            // Use event to indicate the page is moving to a navigator and allow it to be cancelled
            KiwiDockingManager dockingManager = DockingManager;
            if (dockingManager != null)
            {
                CancelUniqueNameEventArgs args = new CancelUniqueNameEventArgs(e.Page.UniqueName, false);
                dockingManager.RaisePageNavigatorRequest(args);

                // Pass back the result of the event
                e.Cancel = args.Cancel;
            }
        }
        #endregion
    }
}
