namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSubassembly 
	{
		public AeccXRoadwayLib.IAeccSubassembly _i;
		internal AeccSubassembly(object AeccSubassembly_object) 
		{
			this._i = AeccSubassembly_object as AeccXRoadwayLib.IAeccSubassembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public dynamic GeometryGenerateMode => this._i.GeometryGenerateMode;

		///<summary>
		///
		///</summary>
		public void Set_GeometryGenerateMode(AeccXRoadwayLib.AeccSubassemblyGeometryGenerateMode pVal) 
		{
			this._i.GeometryGenerateMode = pVal;
		}

		///<summary>
		///
		///</summary>
		public string MacroName => this._i.MacroName;

		///<summary>
		///
		///</summary>
		public void Set_MacroName(string pVal) 
		{
			this._i.MacroName = pVal;
		}

		///<summary>
		///
		///</summary>
		public string MacroProject => this._i.MacroProject;

		///<summary>
		///
		///</summary>
		public void Set_MacroProject(string pVal) 
		{
			this._i.MacroProject = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DotNetClassName => this._i.DotNetClassName;

		///<summary>
		///
		///</summary>
		public void Set_DotNetClassName(string pVal) 
		{
			this._i.DotNetClassName = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DotNetAssemblyName => this._i.DotNetAssemblyName;

		///<summary>
		///
		///</summary>
		public void Set_DotNetAssemblyName(string pVal) 
		{
			this._i.DotNetAssemblyName = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsBool => this._i.ParamsBool;

		///<summary>
		///
		///</summary>
		public void Set_ParamsBool(dynamic pVal) 
		{
			this._i.ParamsBool = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsLong => this._i.ParamsLong;

		///<summary>
		///
		///</summary>
		public void Set_ParamsLong(dynamic pVal) 
		{
			this._i.ParamsLong = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsDouble => this._i.ParamsDouble;

		///<summary>
		///
		///</summary>
		public void Set_ParamsDouble(dynamic pVal) 
		{
			this._i.ParamsDouble = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ParamsString => this._i.ParamsString;

		///<summary>
		///
		///</summary>
		public void Set_ParamsString(dynamic pVal) 
		{
			this._i.ParamsString = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Points => this._i.Points;

		///<summary>
		///
		///</summary>
		public void Set_Points(dynamic ppVal) 
		{
			this._i.Points = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Links => this._i.Links;

		///<summary>
		///
		///</summary>
		public void Set_Links(dynamic pVal) 
		{
			this._i.Links = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Shapes => this._i.Shapes;

		///<summary>
		///
		///</summary>
		public void Set_Shapes(dynamic pVal) 
		{
			this._i.Shapes = pVal;
		}

		///<summary>
		///
		///</summary>
		public void RunMacro() 
		{
			this._i.RunMacro();
		}

		///<summary>
		///
		///</summary>
		public void Run() 
		{
			this._i.Run();
		}

		///<summary>
		///
		///</summary>
		public double DefaultLoopOffsetInLayoutMode => this._i.DefaultLoopOffsetInLayoutMode;

		///<summary>
		///
		///</summary>
		public void Set_DefaultLoopOffsetInLayoutMode(double pdblOffset) 
		{
			this._i.DefaultLoopOffsetInLayoutMode = pdblOffset;
		}

		///<summary>
		///
		///</summary>
		public bool DefaultLoopInLayoutMode => this._i.DefaultLoopInLayoutMode;

		///<summary>
		///
		///</summary>
		public void Set_DefaultLoopInLayoutMode(bool pbLastPointInList) 
		{
			this._i.DefaultLoopInLayoutMode = pbLastPointInList;
		}

		///<summary>
		///
		///</summary>
		public void EraseAllParams() 
		{
			this._i.EraseAllParams();
		}

		///<summary>
		///
		///</summary>
		public bool IsDynamic => this._i.IsDynamic;

		///<summary>
		///
		///</summary>
		public string CodeSetStyleName => this._i.CodeSetStyleName;

		///<summary>
		///
		///</summary>
		public void Set_CodeSetStyleName(string pbstrName) 
		{
			this._i.CodeSetStyleName = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public bool UseEmbeddedProject => this._i.UseEmbeddedProject;

		///<summary>
		///
		///</summary>
		public void Set_UseEmbeddedProject(bool pbUseEmbeddedProject) 
		{
			this._i.UseEmbeddedProject = pbUseEmbeddedProject;
		}

		///<summary>
		///
		///</summary>
		public void ShowHelp() 
		{
			this._i.ShowHelp();
		}

		///<summary>
		///
		///</summary>
		public string HelpFile => this._i.HelpFile;

		///<summary>
		///
		///</summary>
		public void Set_HelpFile(string pVal) 
		{
			this._i.HelpFile = pVal;
		}

		///<summary>
		///
		///</summary>
		public string HelpCommand => this._i.HelpCommand;

		///<summary>
		///
		///</summary>
		public void Set_HelpCommand(string pVal) 
		{
			this._i.HelpCommand = pVal;
		}

		///<summary>
		///
		///</summary>
		public string HelpData => this._i.HelpData;

		///<summary>
		///
		///</summary>
		public void Set_HelpData(string pVal) 
		{
			this._i.HelpData = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ResourceModule => this._i.ResourceModule;

		///<summary>
		///
		///</summary>
		public void Set_ResourceModule(string pVal) 
		{
			this._i.ResourceModule = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ContentLocation => this._i.ContentLocation;

		///<summary>
		///
		///</summary>
		public void Set_ContentLocation(string pVal) 
		{
			this._i.ContentLocation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsConditionalSA => this._i.IsConditionalSA;

		///<summary>
		///
		///</summary>
		public void Set_IsConditionalSA(bool pbIsConditionalSA) 
		{
			this._i.IsConditionalSA = pbIsConditionalSA;
		}

		///<summary>
		///
		///</summary>
		public string GetResourceString(dynamic long) 
		{
			return this._i.GetResourceString(long);
		}

		///<summary>
		///
		///</summary>
		public string GetResourceStringEx(string nId) 
		{
			return this._i.GetResourceStringEx(nId);
		}

		///<summary>
		///
		///</summary>
		public dynamic Assembly => this._i.Assembly;
	}
}
