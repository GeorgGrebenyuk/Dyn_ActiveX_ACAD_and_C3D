namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignment 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignment _i;
		internal AeccAlignment(object AeccAlignment_object) 
		{
			this._i = AeccAlignment_object as Autodesk.AECC.Interop.Land.IAeccAlignment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		public dynamic Style => this._i.get_Style();
		public void Set_Style(object Style)
		{
            this._i.set_Style(Style);

        }

		///<summary>
		///
		///</summary>
		public object ReferencePoint => this._i.ReferencePoint;

		///<summary>
		///
		///</summary>
		public void Set_ReferencePoint(object RefPoint) 
		{
			this._i.ReferencePoint = RefPoint;
		}

		///<summary>
		///
		///</summary>
		public double ReferencePointStation => this._i.ReferencePointStation;

		///<summary>
		///
		///</summary>
		public void Set_ReferencePointStation(double StationValue) 
		{
			this._i.ReferencePointStation = StationValue;
		}

		///<summary>
		///
		///</summary>
		public double StartingStation => this._i.StartingStation;

		///<summary>
		///
		///</summary>
		public double EndingStation => this._i.EndingStation;

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public bool ReverseStationing => this._i.ReverseStationing;

		///<summary>
		///
		///</summary>
		public void Set_ReverseStationing(bool pVal) 
		{
			this._i.ReverseStationing = pVal;
		}

		///<summary>
		///
		///</summary>
		public void StationOffset(double Easting,double Northing,out double Station,out double Offset) 
		{
			this._i.StationOffset(Easting,Northing,out Station,out Offset);
		}

		///<summary>
		///
		///</summary>
		public void PointLocation(double Station,double Offset,out double Easting,out double Northing) 
		{
			this._i.PointLocation(Station,Offset,out Easting,out Northing);
		}

		///<summary>
		///
		///</summary>
		public dynamic Entities => this._i.Entities;

		///<summary>
		///
		///</summary>
		public dynamic GetStations(Autodesk.AECC.Interop.Land.AeccStationType StationType,double MajorInterval,double MinorInterval) 
		{
			return this._i.GetStations(StationType,MajorInterval,MinorInterval);
		}

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeeds => this._i.DesignSpeeds;

		///<summary>
		///
		///</summary>
		public dynamic StationEquations => this._i.StationEquations;

		///<summary>
		///
		///</summary>
		public dynamic LabelSet => this._i.LabelSet;

		///<summary>
		///
		///</summary>
		public dynamic Profiles => this._i.Profiles;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViews => this._i.ProfileViews;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineGroups => this._i.SampleLineGroups;

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///
		///</summary>
		public void ImportLabelSet(dynamic LabelStyleSet) 
		{
			this._i.ImportLabelSet(LabelStyleSet);
		}

		///<summary>
		///
		///</summary>
		public dynamic ExportLabelSet(string Name) 
		{
			return this._i.ExportLabelSet(Name);
		}

		///<summary>
		///
		///</summary>
		public dynamic StationOffsetEx(double Easting,double Northing,double Tolerance,out double Station,out double Offset) 
		{
			return this._i.StationOffsetEx(Easting,Northing,Tolerance,out Station,out Offset);
		}

		///<summary>
		///
		///</summary>
		public dynamic PointLocationEx(double Station,double Offset,double Tolerance,out double Easting,out double Northing,out double Bearing) 
		{
			return this._i.PointLocationEx(Station,Offset,Tolerance,out Easting,out Northing,out Bearing);
		}

		///<summary>
		///
		///</summary>
		public void Offset(double Distance) 
		{
			this._i.Offset(Distance);
		}

		///<summary>
		///
		///</summary>
		public void DistanceToAlignment(double StationOnThisAlignment,dynamic pOtherAlignment,out double DistanceToOtherAlignment,out double StationOnOtherAlignment,Autodesk.AECC.Interop.Land.AeccSideToAlignmentType side) 
		{
			this._i.DistanceToAlignment(StationOnThisAlignment,pOtherAlignment,out DistanceToOtherAlignment,out StationOnOtherAlignment,side);
		}

		///<summary>
		///
		///</summary>
		public string GetStationStringWithEquations(double dRawStation) 
		{
			return this._i.GetStationStringWithEquations(dRawStation);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetLWPolyline => this._i.GetLWPolyline();

		///<summary>
		///
		///</summary>
		public void Reverse() 
		{
			this._i.Reverse();
		}

		///<summary>
		///
		///</summary>
		public double InstantaneousRadius(double dRawStation) 
		{
			return this._i.InstantaneousRadius[dRawStation];
		}

		///<summary>
		///
		///</summary>
		public double StationIndexIncrement => this._i.StationIndexIncrement;

		///<summary>
		///
		///</summary>
		public void Set_StationIndexIncrement(double pVal) 
		{
			this._i.StationIndexIncrement = pVal;
		}

		///<summary>
		///
		///</summary>
		public void MoveToSiteless() 
		{
			this._i.MoveToSiteless();
		}

		///<summary>
		///
		///</summary>
		public dynamic Labels => this._i.Labels;

		///<summary>
		///
		///</summary>
		public dynamic LabelGroups => this._i.LabelGroups;

		///<summary>
		///
		///</summary>
		public bool DesignSpeedBased => this._i.DesignSpeedBased;

		///<summary>
		///
		///</summary>
		public void Set_DesignSpeedBased(bool bValue) 
		{
			this._i.DesignSpeedBased = bValue;
		}

		///<summary>
		///
		///</summary>
		public bool UseDesignCriteriaFile => this._i.UseDesignCriteriaFile;

		///<summary>
		///
		///</summary>
		public void Set_UseDesignCriteriaFile(bool bValue) 
		{
			this._i.UseDesignCriteriaFile = bValue;
		}

		///<summary>
		///
		///</summary>
		public bool UseDesignCheckSet => this._i.UseDesignCheckSet;

		///<summary>
		///
		///</summary>
		public void Set_UseDesignCheckSet(bool bValue) 
		{
			this._i.UseDesignCheckSet = bValue;
		}
	}
}
