namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMLeader 
	{
		public AXDBLib.IAcadMLeader _i;
		internal AcadMLeader(object AcadMLeader_object) 
		{
			this._i = AcadMLeader_object as AXDBLib.IAcadMLeader;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double scale) 
		{
			this._i.ScaleFactor = scale;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderType => this._i.LeaderType;

		///<summary>
		///
		///</summary>
		public void Set_LeaderType(AXDBLib.AcMLeaderType Type) 
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
		public dynamic LeaderLinetype => this._i.LeaderLinetype;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLinetype(dynamic Linetype) 
		{
			this._i.LeaderLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderLineWeight => this._i.LeaderLineWeight;

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
		public dynamic ArrowheadType => this._i.ArrowheadType;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadType(AXDBLib.AcDimArrowheadType BlockName) 
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
		public bool DogLegged => this._i.DogLegged;

		///<summary>
		///
		///</summary>
		public void Set_DogLegged(bool val) 
		{
			this._i.DogLegged = val;
		}

		///<summary>
		///
		///</summary>
		public double DoglegLength => this._i.DoglegLength;

		///<summary>
		///
		///</summary>
		public void Set_DoglegLength(double DoglegLength) 
		{
			this._i.DoglegLength = DoglegLength;
		}

		///<summary>
		///
		///</summary>
		public string ContentBlockName => this._i.ContentBlockName;

		///<summary>
		///
		///</summary>
		public void Set_ContentBlockName(string BlockName) 
		{
			this._i.ContentBlockName = BlockName;
		}

		///<summary>
		///
		///</summary>
		public dynamic BlockConnectionType => this._i.BlockConnectionType;

		///<summary>
		///
		///</summary>
		public void Set_BlockConnectionType(AXDBLib.AcBlockConnectionType Type) 
		{
			this._i.BlockConnectionType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic BlockScale => this._i.BlockScale;

		///<summary>
		///
		///</summary>
		public void Set_BlockScale(dynamic factor) 
		{
			this._i.BlockScale = factor;
		}

		///<summary>
		///
		///</summary>
		public string TextString => this._i.TextString;

		///<summary>
		///
		///</summary>
		public void Set_TextString(string bstrText) 
		{
			this._i.TextString = bstrText;
		}

		///<summary>
		///
		///</summary>
		public string TextStyleName => this._i.TextStyleName;

		///<summary>
		///
		///</summary>
		public void Set_TextStyleName(string bstrName) 
		{
			this._i.TextStyleName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextJustify => this._i.TextJustify;

		///<summary>
		///
		///</summary>
		public void Set_TextJustify(AXDBLib.AcAttachmentPoint attPoint) 
		{
			this._i.TextJustify = attPoint;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextDirection => this._i.TextDirection;

		///<summary>
		///
		///</summary>
		public void Set_TextDirection(AXDBLib.AcDrawingDirection drawDir) 
		{
			this._i.TextDirection = drawDir;
		}

		///<summary>
		///
		///</summary>
		public double TextWidth => this._i.TextWidth;

		///<summary>
		///
		///</summary>
		public void Set_TextWidth(double Width) 
		{
			this._i.TextWidth = Width;
		}

		///<summary>
		///
		///</summary>
		public double TextHeight => this._i.TextHeight;

		///<summary>
		///
		///</summary>
		public void Set_TextHeight(double Height) 
		{
			this._i.TextHeight = Height;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextRotation => this._i.TextRotation;

		///<summary>
		///
		///</summary>
		public void Set_TextRotation(dynamic rotAngle) 
		{
			this._i.TextRotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public double TextLineSpacingFactor => this._i.TextLineSpacingFactor;

		///<summary>
		///
		///</summary>
		public void Set_TextLineSpacingFactor(double factor) 
		{
			this._i.TextLineSpacingFactor = factor;
		}

		///<summary>
		///
		///</summary>
		public double TextLineSpacingDistance => this._i.TextLineSpacingDistance;

		///<summary>
		///
		///</summary>
		public void Set_TextLineSpacingDistance(double Value) 
		{
			this._i.TextLineSpacingDistance = Value;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextLineSpacingStyle => this._i.TextLineSpacingStyle;

		///<summary>
		///
		///</summary>
		public void Set_TextLineSpacingStyle(AXDBLib.AcLineSpacingStyle style) 
		{
			this._i.TextLineSpacingStyle = style;
		}

		///<summary>
		///
		///</summary>
		public bool TextBackgroundFill => this._i.TextBackgroundFill;

		///<summary>
		///
		///</summary>
		public void Set_TextBackgroundFill(bool bUseBackgroundFill) 
		{
			this._i.TextBackgroundFill = bUseBackgroundFill;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextAttachmentDirection => this._i.TextAttachmentDirection;

		///<summary>
		///
		///</summary>
		public void Set_TextAttachmentDirection(AXDBLib.AcTextAttachmentDirection dir) 
		{
			this._i.TextAttachmentDirection = dir;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextLeftAttachmentType => this._i.TextLeftAttachmentType;

		///<summary>
		///
		///</summary>
		public void Set_TextLeftAttachmentType(AXDBLib.AcTextAttachmentType Type) 
		{
			this._i.TextLeftAttachmentType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextRightAttachmentType => this._i.TextRightAttachmentType;

		///<summary>
		///
		///</summary>
		public void Set_TextRightAttachmentType(AXDBLib.AcTextAttachmentType Type) 
		{
			this._i.TextRightAttachmentType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextTopAttachmentType => this._i.TextTopAttachmentType;

		///<summary>
		///
		///</summary>
		public void Set_TextTopAttachmentType(AXDBLib.AcVerticalTextAttachmentType Type) 
		{
			this._i.TextTopAttachmentType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextBottomAttachmentType => this._i.TextBottomAttachmentType;

		///<summary>
		///
		///</summary>
		public void Set_TextBottomAttachmentType(AXDBLib.AcVerticalTextAttachmentType Type) 
		{
			this._i.TextBottomAttachmentType = Type;
		}

		///<summary>
		///
		///</summary>
		public double LandingGap => this._i.LandingGap;

		///<summary>
		///
		///</summary>
		public void Set_LandingGap(double gap) 
		{
			this._i.LandingGap = gap;
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

		///<summary>
		///
		///</summary>
		public dynamic ContentBlockType => this._i.ContentBlockType;

		///<summary>
		///
		///</summary>
		public void Set_ContentBlockType(AXDBLib.AcPredefBlockType Type) 
		{
			this._i.ContentBlockType = Type;
		}

		///<summary>
		///
		///</summary>
		public int LeaderCount => this._i.LeaderCount;

		///<summary>
		///
		///</summary>
		public int AddLeader => this._i.AddLeader();

		///<summary>
		///
		///</summary>
		public void RemoveLeader(int leaderIndex) 
		{
			this._i.RemoveLeader(leaderIndex);
		}

		///<summary>
		///
		///</summary>
		public int AddLeaderLine(int leaderIndex,object pointArray) 
		{
			return this._i.AddLeaderLine(leaderIndex,pointArray);
		}

		///<summary>
		///
		///</summary>
		public int AddLeaderLineEx(object pointArray) 
		{
			return this._i.AddLeaderLineEx(pointArray);
		}

		///<summary>
		///
		///</summary>
		public void RemoveLeaderLine(int leaderLineIndex) 
		{
			this._i.RemoveLeaderLine(leaderLineIndex);
		}

		///<summary>
		///
		///</summary>
		public void SetLeaderLineVertices(int leaderLineIndex,object pointArray) 
		{
			this._i.SetLeaderLineVertices(leaderLineIndex,pointArray);
		}

		///<summary>
		///
		///</summary>
		public object GetLeaderLineVertices(int leaderLineIndex) 
		{
			return this._i.GetLeaderLineVertices(leaderLineIndex);
		}

		///<summary>
		///
		///</summary>
		public void Set_ContentType(AXDBLib.AcMLeaderContentType Type) 
		{
			this._i.ContentType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic ContentType => this._i.ContentType;

		///<summary>
		///
		///</summary>
		public int GetLeaderIndex(int leaderLineIndex) 
		{
			return this._i.GetLeaderIndex(leaderLineIndex);
		}

		///<summary>
		///
		///</summary>
		public object GetLeaderLineIndexes(int leaderIndex) 
		{
			return this._i.GetLeaderLineIndexes(leaderIndex);
		}

		///<summary>
		///
		///</summary>
		public int GetVertexCount(int leaderLineIndex) 
		{
			return this._i.GetVertexCount(leaderLineIndex);
		}

		///<summary>
		///
		///</summary>
		public bool TextFrameDisplay => this._i.TextFrameDisplay;

		///<summary>
		///
		///</summary>
		public void Set_TextFrameDisplay(bool pVal) 
		{
			this._i.TextFrameDisplay = pVal;
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public void Set_StyleName(string Name) 
		{
			this._i.StyleName = Name;
		}

		///<summary>
		///
		///</summary>
		public object GetDoglegDirection(int leaderIndex) 
		{
			return this._i.GetDoglegDirection(leaderIndex);
		}

		///<summary>
		///
		///</summary>
		public void SetDoglegDirection(int leaderIndex,object dirVec) 
		{
			this._i.SetDoglegDirection(leaderIndex,dirVec);
		}

		///<summary>
		///
		///</summary>
		public string GetBlockAttributeValue(dynamic attdefId) 
		{
			return this._i.GetBlockAttributeValue(attdefId);
		}

		///<summary>
		///
		///</summary>
		public void SetBlockAttributeValue(dynamic attdefId,string Value) 
		{
			this._i.SetBlockAttributeValue(attdefId,Value);
		}
	}
}
