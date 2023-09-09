namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCustomSubassembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCustomSubassembly _i;
		internal AeccCustomSubassembly(object AeccCustomSubassembly_object) 
		{
			this._i = AeccCustomSubassembly_object as Autodesk.AECC.Interop.Roadway.IAeccCustomSubassembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void GetLogicalNames(dynamic piRoadwayState) 
		{
			this._i.GetLogicalNames(piRoadwayState);
		}

		///<summary>
		///
		///</summary>
		public void GetInputParameters(dynamic piRoadwayState) 
		{
			this._i.GetInputParameters(piRoadwayState);
		}

		///<summary>
		///
		///</summary>
		public void GetOutputParameters(dynamic piRoadwayState) 
		{
			this._i.GetOutputParameters(piRoadwayState);
		}

		///<summary>
		///
		///</summary>
		public void Run(dynamic piRoadwayState) 
		{
			this._i.Run(piRoadwayState);
		}
	}
}
