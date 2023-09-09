namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentEntities 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentEntities _i;
		internal AeccAlignmentEntities(object AeccAlignmentEntities_object) 
		{
			this._i = AeccAlignmentEntities_object as Autodesk.AECC.Interop.Land.IAeccAlignmentEntities;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic EntityAtId(dynamic EntityId) 
		{
			return this._i.EntityAtId(EntityId);
		}

		///<summary>
		///
		///</summary>
		public dynamic EntityAtStation(double Station) 
		{
			return this._i.EntityAtStation(Station);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedLine1(object StartPoint,object EndPoint) 
		{
			return this._i.AddFixedLine1(StartPoint,EndPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedLine2(dynamic PreviousElementId,double Distance) 
		{
			return this._i.AddFixedLine2(PreviousElementId,Distance);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedLine3(dynamic PreviousElementId,object StartPoint,object EndPoint) 
		{
			return this._i.AddFixedLine3(PreviousElementId,StartPoint,EndPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve1(dynamic PreviousElementId,object StartPoint,object MiddlePoint,object EndPoint) 
		{
			return this._i.AddFixedCurve1(PreviousElementId,StartPoint,MiddlePoint,EndPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve2(object CenterPoint,double Radius,bool IsClockwise) 
		{
			return this._i.AddFixedCurve2(CenterPoint,Radius,IsClockwise);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve3(object CenterPoint,object PassThroughPoint,bool IsClockwise) 
		{
			return this._i.AddFixedCurve3(CenterPoint,PassThroughPoint,IsClockwise);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve4(object PassThroughPoint1,object DirectionAtPassThroughPoint1,object PassThroughPoint2) 
		{
			return this._i.AddFixedCurve4(PassThroughPoint1,DirectionAtPassThroughPoint1,PassThroughPoint2);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve5(object PassThroughPoint1,object PassThroughPoint2,object DirectionAtPassThroughPoint2) 
		{
			return this._i.AddFixedCurve5(PassThroughPoint1,PassThroughPoint2,DirectionAtPassThroughPoint2);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve6(object PassThroughPoint1,object PassThroughPoint2,double Radius,bool IsClockwise) 
		{
			return this._i.AddFixedCurve6(PassThroughPoint1,PassThroughPoint2,Radius,IsClockwise);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve7(object PassThroughPoint1,object DirectionAtPassThroughPoint1,double Radius,bool IsClockwise) 
		{
			return this._i.AddFixedCurve7(PassThroughPoint1,DirectionAtPassThroughPoint1,Radius,IsClockwise);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedCurve8(dynamic PreviousElementId,object PassThroughPoint) 
		{
			return this._i.AddFixedCurve8(PreviousElementId,PassThroughPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeLine(dynamic PreviousElementId,dynamic NextElementId) 
		{
			return this._i.AddFreeLine(PreviousElementId,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeCurve1(dynamic PreviousElementId,dynamic NextElementId,Autodesk.AECC.Interop.Land.AeccAlignmentFreeCurveConstraintType ConstraintType,double ConstraintValue,bool GreaterThan180,Autodesk.AECC.Interop.Land.AeccAlignmentFreeCurveType CurveType) 
		{
			return this._i.AddFreeCurve1(PreviousElementId,NextElementId,ConstraintType,ConstraintValue,GreaterThan180,CurveType);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeCurve2(dynamic PreviousElementId,dynamic NextElementId,object PassThroughPoint) 
		{
			return this._i.AddFreeCurve2(PreviousElementId,NextElementId,PassThroughPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSCSGroup1(dynamic PreviousElementId,dynamic NextElementId,double Spiral1Length,double Radius,double Spiral2Length,bool GreaterThan180,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFreeSCSGroup1(PreviousElementId,NextElementId,Spiral1Length,Radius,Spiral2Length,GreaterThan180,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSCSGroup2(dynamic PreviousElementId,dynamic NextElementId,double Spiral1AValue,double Radius,double Spiral2AValue,bool GreaterThan180,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFreeSCSGroup2(PreviousElementId,NextElementId,Spiral1AValue,Radius,Spiral2AValue,GreaterThan180,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingLine1(dynamic PreviousElementId,object PassThroughPoint) 
		{
			return this._i.AddFloatingLine1(PreviousElementId,PassThroughPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingLine2(dynamic PreviousElementId,double Length) 
		{
			return this._i.AddFloatingLine2(PreviousElementId,Length);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingLine3(object PassThroughPoint,dynamic NextElementId) 
		{
			return this._i.AddFloatingLine3(PassThroughPoint,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingLine4(double Length,dynamic NextElementId) 
		{
			return this._i.AddFloatingLine4(Length,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingLine5(dynamic nElementId,bool bAppend,double dSpParam,bool bIsSpParamAValue,object ptPassThru,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFloatingLine5(nElementId,bAppend,dSpParam,bIsSpParamAValue,ptPassThru,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingLine6(dynamic nElementId,bool bAppend,double dSpParam,bool bIsSpParamAValue,double dTanLength,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFloatingLine6(nElementId,bAppend,dSpParam,bIsSpParamAValue,dTanLength,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve1(dynamic PreviousElementId,object PassThroughPoint,double Radius,bool GreaterThan180,Autodesk.AECC.Interop.Land.AeccAlignmentFloatingCurveType CurveType) 
		{
			return this._i.AddFloatingCurve1(PreviousElementId,PassThroughPoint,Radius,GreaterThan180,CurveType);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve2(object PassThroughPoint,object DirectionAtPassThroughPoint,dynamic NextElementId) 
		{
			return this._i.AddFloatingCurve2(PassThroughPoint,DirectionAtPassThroughPoint,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve3(object PassThroughPoint,dynamic NextElementId) 
		{
			return this._i.AddFloatingCurve3(PassThroughPoint,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve4(object PassThroughPoint,double Radius,bool GreaterThan180,Autodesk.AECC.Interop.Land.AeccAlignmentFloatingCurveType CurveType,dynamic NextElementId) 
		{
			return this._i.AddFloatingCurve4(PassThroughPoint,Radius,GreaterThan180,CurveType,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve5(dynamic PreviousElementId,object PassThroughPoint,object DirectionAtPassThroughPoint) 
		{
			return this._i.AddFloatingCurve5(PreviousElementId,PassThroughPoint,DirectionAtPassThroughPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve6(dynamic PreviousElementId,object PassThroughPoint) 
		{
			return this._i.AddFloatingCurve6(PreviousElementId,PassThroughPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve7(dynamic PreviousElementId,double Radius,Autodesk.AECC.Interop.Land.AeccAlignmentFreeCurveConstraintType ConstraintType,double ConstraintValue,bool bClockwise) 
		{
			return this._i.AddFloatingCurve7(PreviousElementId,Radius,ConstraintType,ConstraintValue,bClockwise);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve8(double Radius,Autodesk.AECC.Interop.Land.AeccAlignmentFreeCurveConstraintType ConstraintType,double ConstraintValue,bool bClockwise,dynamic NextElementId) 
		{
			return this._i.AddFloatingCurve8(Radius,ConstraintType,ConstraintValue,bClockwise,NextElementId);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve9(dynamic nElementId,bool bAppend,double dSpParam,double dRadius,object ptPassThrough,bool bGreater180,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition,bool bIsSpParamAValue) 
		{
			return this._i.AddFloatingCurve9(nElementId,bAppend,dSpParam,dRadius,ptPassThrough,bGreater180,spiralDefinition,bIsSpParamAValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFloatingCurve10(dynamic nElementId,bool bAppend,double dSpParam,double dRadius,double dArcLength,bool bIsCW,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition,bool bIsSpParamAValue) 
		{
			return this._i.AddFloatingCurve10(nElementId,bAppend,dSpParam,dRadius,dArcLength,bIsCW,spiralDefinition,bIsSpParamAValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSpiral1(dynamic PreviousElementId,object StartPoint,object SpiralPI,double Radius,double Length,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralCurvatureType SpiralType,bool bClockwise,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFixedSpiral1(PreviousElementId,StartPoint,SpiralPI,Radius,Length,SpiralType,bClockwise,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSpiral2(dynamic PreviousElementId,object StartPoint,object SpiralPI,double StartRadius,double EndRadius,double Length,bool bClockwise,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFixedSpiral2(PreviousElementId,StartPoint,SpiralPI,StartRadius,EndRadius,Length,bClockwise,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFixedSpiral3(dynamic PreviousElementId,object StartPoint,object SpiralPI,object EndPoint,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFixedSpiral3(PreviousElementId,StartPoint,SpiralPI,EndPoint,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSTSGroup1(dynamic nPreviousElementId,dynamic nNextElementId,double dSp1Param,double dSp2Param,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition,bool bIsSpParamAVal) 
		{
			return this._i.AddFreeSTSGroup1(nPreviousElementId,nNextElementId,dSp1Param,dSp2Param,spiralDefinition,bIsSpParamAVal);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFreeSTSGroup2(dynamic nPreviousElement,dynamic nNextElement,double dTanLength,Autodesk.AECC.Interop.Land.AeccAlignmentSpiralType spiralDefinition) 
		{
			return this._i.AddFreeSTSGroup2(nPreviousElement,nNextElement,dTanLength,spiralDefinition);
		}

		///<summary>
		///
		///</summary>
		public void RemoveAll() 
		{
			this._i.RemoveAll();
		}

		///<summary>
		///
		///</summary>
		public void Remove() 
		{
			this._i.Remove();
		}

		///<summary>
		///
		///</summary>
		public dynamic FirstEntity => this._i.FirstEntity;

		///<summary>
		///
		///</summary>
		public dynamic LastEntity => this._i.LastEntity;
	}
}
