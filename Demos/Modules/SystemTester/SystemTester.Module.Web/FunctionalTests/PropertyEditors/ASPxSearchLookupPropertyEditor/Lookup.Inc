﻿;#IncludeFile .\Init.inc

*Navigate PropertyEditors.ASPx Search Lookup Property Editor Lookup Object
*DeleteAllObjects
*Navigate PropertyEditors.ASPx Search Lookup Property Editor Object
*DeleteAllObjects
*ToggleNavigation = True
*Action New
*LClick [NewAction]


*XpandFillForm
 Name = Tolis
*SaveAndClose
*ToggleNavigation = False
*Navigate PropertyEditors.ASPx Search Lookup Property Editor Object
*Action New
*SendKeys oli
*Sleep 2000
*SendKeys 
 Keys = Down;Return
*SaveAndClose
*XpandProcessRecord
 ASPx Search Lookup Property Editor Lookup = Tolis

