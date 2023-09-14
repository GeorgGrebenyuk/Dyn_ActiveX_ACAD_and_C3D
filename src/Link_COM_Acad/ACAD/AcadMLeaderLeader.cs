namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMLeaderLeader 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadMLeaderLeader _i;
		internal AcadMLeaderLeader(object AcadMLeaderLeader_object) 
		{
			this._i = AcadMLeaderLeader_object as Autodesk.AutoCAD.Interop.Common.AcadMLeaderLeader;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderType => this._i.LeaderType;

		///<summary>
		///
		///</summary>
		public void Set_LeaderType(Autodesk.AutoCAD.Interop.Common.AcMLeaderType Type) 
		{
			this._i.LeaderType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderLineColor => this._i.LeaderLineColor;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLineColor(dynamic Type) 
		{
			this._i.LeaderLineColor = Type;
		}

		///<summary>
		///
		///</summary>
		public string LeaderLinetype => this._i.LeaderLinetype;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLinetype(string Linetype) 
		{
			this._i.LeaderLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public object LeaderLineWeight => this._i.LeaderLineWeight;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLineWeight(dynamic Lineweight) 
		{
			this._i.LeaderLineWeight = Lineweight;
		}

		///<summary>
		///
		///</summary>
		public object ArrowheadType => this._i.ArrowheadType;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadType(Autodesk.AutoCAD.Interop.Common.AcDimArrowheadType BlockName) 
		{
			this._i.ArrowheadType = BlockName;
		}

		///<summary>
		///
		///</summary>
		public double ArrowheadSize => this._i.ArrowheadSize;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadSize(double size) 
		{
			this._i.ArrowheadSize = size;
		}

		///<summary>
		///
		///</summary>
		public string ArrowheadBlock => this._i.ArrowheadBlock;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadBlock(string BlockName) 
		{
			this._i.ArrowheadBlock = BlockName;
		}
	}
}
