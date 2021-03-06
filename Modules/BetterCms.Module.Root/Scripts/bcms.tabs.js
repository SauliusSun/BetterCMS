﻿/*jslint unparam: true, white: true, browser: true, devel: true */
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="bcms.tabs.js" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------

bettercms.define('bcms.tabs', ['bcms.jquery', 'bcms'], function ($, bcms) {
    'use strict';

    var tabs = {},

    // Classes that are used to maintain various UI states:
        classes = {
            activeTabLink: 'bcms-active'
        },

    // Selectors used in the module to locate DOM elements:
        selectors = {
            tabContent: '.bcms-tab-single',
            firstTabContent: '.bcms-tab-single:first',
            tabLink: '.bcms-tab-item',
            firstTabLink: 'div.bcms-tab-item:first',
            activeTabLink: '.bcms-active',
            tabsHeader: '.bcms-js-tab-header'
        },

        links = {},

        globalization = {
        };

    /**
    /* Assign objects to module.
    */
    tabs.selectors = selectors;
    tabs.links = links;
    tabs.globalization = globalization;

    /**
    * TabsPanel instance constructor:
    */

    function TabPanel(container, options) {
        options = $.extend({
            skipInit: false
        }, options);

        this.container = container;
        this.options = options;
    }

    TabPanel.prototype = {
        init: function () {
            if (this.options.skipInit) {
                return;
            }
            var instance = this,
                container = this.container;

            container.find(selectors.tabLink).click(function () {
                var tabId = $(this).data('name');
                instance.selectTab(tabId);
                return false;
            });

            this.selectFirstTab();
        },

        selectTab: function (tabId) {
            if (!tabId) {
                return;
            }
            
            if (tabId.indexOf('#') !== 0) {
                tabId = '#' + tabId;
            }

            var tabHeadToActivate = this.container.find('[data-name="' + tabId + '"]'),
                headContainer = tabHeadToActivate.parent()/*.closest(selectors.tabsHeader)*/;
            
            headContainer.find(selectors.activeTabLink).removeClass(classes.activeTabLink);
            tabHeadToActivate.addClass(classes.activeTabLink);
            
            var tabBodyToActivate = this.container.find(tabId),
                bodyContainer = tabBodyToActivate.parent();
            bodyContainer.children(selectors.tabContent).hide();
            tabBodyToActivate.show();
        },

        selectFirstTab: function () {
            var tabId = this.container.find(selectors.firstTabLink).data('name');
            this.selectTab(tabId);
        },

        selectTabOfElement: function (element) {
            var tabId = $(element).parents(selectors.tabContent).attr('id');
            this.selectTab(tabId);
        }
    };

    tabs.initTabPanel = function (container, options) {
        var tabPanel = new TabPanel(container, options);
        tabPanel.init();
        return tabPanel;
    };

    tabs.getTabPanelOfElement = function (element) {
        var tab = $(element).parents(selectors.firstTabContent);

        if (tab.length > 0) {
            var parent = tab.parent();
            var tabsHeader;

            do {
                tabsHeader = parent.find(selectors.tabsHeader);
                parent = parent.parent();
            } while (parent.length !== 0 && tabsHeader.length === 0);

            if (tabsHeader.length !== 0) {
                var tabPanel = new TabPanel(tabsHeader.parent());
                return tabPanel;
            }
        }

        return null;
    };

    return tabs;
});
