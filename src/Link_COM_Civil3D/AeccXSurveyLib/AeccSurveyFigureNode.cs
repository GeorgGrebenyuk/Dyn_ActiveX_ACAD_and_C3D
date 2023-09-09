namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigureNode 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyFigureNode _i;
		internal AeccSurveyFigureNode(object AeccSurveyFigureNode_object) 
		{
			this._i = AeccSurveyFigureNode_object as Autodesk.AECC.Interop.Survey.IAeccSurveyFigureNode;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ID => this._i.ID;

		///<summary>
		///
		///</summary>
		public dynamic NodeNumber => this._i.NodeNumber;

		///<summary>
		///
		///</summary>
		public double X => this._i.X;

		///<summary>
		///
		///</summary>
		public void Set_X(double pdX) 
		{
			this._i.X = pdX;
		}

		///<summary>
		///
		///</summary>
		public double Y => this._i.Y;

		///<summary>
		///
		///</summary>
		public void Set_Y(double pdY) 
		{
			this._i.Y = pdY;
		}

		///<summary>
		///
		///</summary>
		public double Z => this._i.Z;

		///<summary>
		///
		///</summary>
		public void Set_Z(double pdZ) 
		{
			this._i.Z = pdZ;
		}

		///<summary>
		///
		///</summary>
		public double Bulge => this._i.Bulge;

		///<summary>
		///
		///</summary>
		public void Set_Bulge(double pdBulge) 
		{
			this._i.Bulge = pdBulge;
		}

		///<summary>
		///
		///</summary>
		public dynamic Point0 => this._i.Point0;

		///<summary>
		///
		///</summary>
		public void Set_Point0(dynamic pnPoint0) 
		{
			this._i.Point0 = pnPoint0;
		}

		///<summary>
		///
		///</summary>
		public dynamic Point1 => this._i.Point1;

		///<summary>
		///
		///</summary>
		public void Set_Point1(dynamic pnPoint1) 
		{
			this._i.Point1 = pnPoint1;
		}

		///<summary>
		///
		///</summary>
		public double Data0 => this._i.Data0;

		///<summary>
		///
		///</summary>
		public void Set_Data0(double pdData0) 
		{
			this._i.Data0 = pdData0;
		}

		///<summary>
		///
		///</summary>
		public double Data1 => this._i.Data1;

		///<summary>
		///
		///</summary>
		public void Set_Data1(double pdData1) 
		{
			this._i.Data1 = pdData1;
		}

		///<summary>
		///
		///</summary>
		public double Data2 => this._i.Data2;

		///<summary>
		///
		///</summary>
		public void Set_Data2(double pdData2) 
		{
			this._i.Data2 = pdData2;
		}

		///<summary>
		///
		///</summary>
		public double Data3 => this._i.Data3;

		///<summary>
		///
		///</summary>
		public void Set_Data3(double pdData3) 
		{
			this._i.Data3 = pdData3;
		}

		///<summary>
		///
		///</summary>
		public dynamic Code => this._i.Code;

		///<summary>
		///
		///</summary>
		public void Set_Code(Autodesk.AECC.Interop.Survey.AeccSurveyFigureNodeCode pNodeCode) 
		{
			this._i.Code = pNodeCode;
		}
	}
}
