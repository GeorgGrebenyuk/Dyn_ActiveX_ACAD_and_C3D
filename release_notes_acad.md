# Release notes of Link_COM_Acad

## Version 0.1.10

### Updates:

* AcadDocument: one of constructor is hide (that using in Python-node);
* AcadApplication: new node for Connect to Acad 2025;
* Migrate to Dynamo 3.0 (.NET8);

## Version 0.1.9 (26.10.2023, 08:40 UTC)

### Updates:

* AcadMLeader: adding constructor as casting from AcadEntity;

## Version 0.1.8 (23.10.2023, 20:30 UTC)

### Updates:

* Repairing methods `Coordinate` and `Coordinates` for linear objects are not working correctly (Coordinates don't returns last coordinate; Coordinate don't return any coordinate);

### Adding:

* New CustomNode ConnectToAcadDoc.dyf for getting AcadDocument from node `Document.Current` from Civil 3D Dynamo (there using small Python-node with that method https://help.autodesk.com/view/OARX/2024/ENU/?guid=OARX-ManagedRefGuide-Autodesk_AutoCAD_ApplicationServices_DocumentExtension_GetAcadDocument_this_Document);


## Version 0.1.7 (05.10.2023, 18:30 UTC)

### Updates:

* Ellipse constructor: MajorAxis argument is Point;
* Acad3DPoly constructor: internal update of method (works incorrectly);
* AcadHatch constructor: PatternType's argument is cast to AcPatternType;
* AcadLeader constructor: adding new (for Annotation = null case);
* AcadSpline constructor internal update of method (works incorrectly);
* AddRevolvedSolid constructor: internal update of method (works incorrectly);
* CheckInterference constructor: internal update of method (works incorrectly);

### Adding:

*AcadSelectionSet and AcadSelectionSets classes with mthods;
* new methods to AcadDocument class (such as ActiveLayer, ActiveLayout and etc);

## Version 0.1.6

First stable version