namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadMLeaderStyle 
	{
		public AXDBLib.IAcadMLeaderStyle _i;
		internal AcadMLeaderStyle(object AcadMLeaderStyle_object) 
		{
			this._i = AcadMLeaderStyle_object as AXDBLib.IAcadMLeaderStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string Name) 
		{
			this._i.Name = Name;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string Description) 
		{
			this._i.Description = Description;
		}

		///<summary>
		///
		///</summary>
		public dynamic BitFlags => this._i.BitFlags;

		///<summary>
		///
		///</summary>
		public void Set_BitFlags(dynamic bitFlag) 
		{
			this._i.BitFlags = bitFlag;
		}

		///<summary>
		///
		///</summary>
		public dynamic ContentType => this._i.ContentType;

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
		public dynamic DrawMLeaderOrderType => this._i.DrawMLeaderOrderType;

		///<summary>
		///
		///</summary>
		public void Set_DrawMLeaderOrderType(AXDBLib.AcDrawMLeaderOrderType Type) 
		{
			this._i.DrawMLeaderOrderType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrawLeaderOrderType => this._i.DrawLeaderOrderType;

		///<summary>
		///
		///</summary>
		public void Set_DrawLeaderOrderType(AXDBLib.AcDrawLeaderOrderType Type) 
		{
			this._i.DrawLeaderOrderType = Type;
		}

		///<summary>
		///
		///</summary>
		public int MaxLeaderSegmentsPoints => this._i.MaxLeaderSegmentsPoints;

		///<summary>
		///
		///</summary>
		public void Set_MaxLeaderSegmentsPoints(int number) 
		{
			this._i.MaxLeaderSegmentsPoints = number;
		}

		///<summary>
		///
		///</summary>
		public dynamic FirstSegmentAngleConstraint => this._i.FirstSegmentAngleConstraint;

		///<summary>
		///
		///</summary>
		public void Set_FirstSegmentAngleConstraint(AXDBLib.AcSegmentAngleType constraint) 
		{
			this._i.FirstSegmentAngleConstraint = constraint;
		}

		///<summary>
		///
		///</summary>
		public dynamic SecondSegmentAngleConstraint => this._i.SecondSegmentAngleConstraint;

		///<summary>
		///
		///</summary>
		public void Set_SecondSegmentAngleConstraint(AXDBLib.AcSegmentAngleType constraint) 
		{
			this._i.SecondSegmentAngleConstraint = constraint;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderLinetype => this._i.LeaderLinetype;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLinetype(AXDBLib.AcMLeaderType Type) 
		{
			this._i.LeaderLinetype = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderLineColor => this._i.LeaderLineColor;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLineColor(dynamic color) 
		{
			this._i.LeaderLineColor = color;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderLineTypeId => this._i.LeaderLineTypeId;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLineTypeId(dynamic Type) 
		{
			this._i.LeaderLineTypeId = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderLineWeight => this._i.LeaderLineWeight;

		///<summary>
		///
		///</summary>
		public void Set_LeaderLineWeight(AXDBLib.AcLineWeight weight) 
		{
			this._i.LeaderLineWeight = weight;
		}

		///<summary>
		///
		///</summary>
		public bool EnableLanding => this._i.EnableLanding;

		///<summary>
		///
		///</summary>
		public void Set_EnableLanding(bool enabled) 
		{
			this._i.EnableLanding = enabled;
		}

		///<summary>
		///
		///</summary>
		public double LandingGap => this._i.LandingGap;

		///<summary>
		///
		///</summary>
		public void Set_LandingGap(double LandingGap) 
		{
			this._i.LandingGap = LandingGap;
		}

		///<summary>
		///
		///</summary>
		public bool EnableDogleg => this._i.EnableDogleg;

		///<summary>
		///
		///</summary>
		public void Set_EnableDogleg(bool enabled) 
		{
			this._i.EnableDogleg = enabled;
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
		public string ArrowSymbol => this._i.ArrowSymbol;

		///<summary>
		///
		///</summary>
		public void Set_ArrowSymbol(string Name) 
		{
			this._i.ArrowSymbol = Name;
		}

		///<summary>
		///
		///</summary>
		public double ArrowSize => this._i.ArrowSize;

		///<summary>
		///
		///</summary>
		public void Set_ArrowSize(double size) 
		{
			this._i.ArrowSize = size;
		}

		///<summary>
		///
		///</summary>
		public string TextStyle => this._i.TextStyle;

		///<summary>
		///
		///</summary>
		public void Set_TextStyle(string Name) 
		{
			this._i.TextStyle = Name;
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
		public dynamic TextColor => this._i.TextColor;

		///<summary>
		///
		///</summary>
		public void Set_TextColor(dynamic color) 
		{
			this._i.TextColor = color;
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
		public bool EnableFrameText => this._i.EnableFrameText;

		///<summary>
		///
		///</summary>
		public void Set_EnableFrameText(bool enabled) 
		{
			this._i.EnableFrameText = enabled;
		}

		///<summary>
		///
		///</summary>
		public double AlignSpace => this._i.AlignSpace;

		///<summary>
		///
		///</summary>
		public void Set_AlignSpace(double AlignSpace) 
		{
			this._i.AlignSpace = AlignSpace;
		}

		///<summary>
		///
		///</summary>
		public string Block => this._i.Block;

		///<summary>
		///
		///</summary>
		public void Set_Block(string Name) 
		{
			this._i.Block = Name;
		}

		///<summary>
		///
		///</summary>
		public dynamic BlockColor => this._i.BlockColor;

		///<summary>
		///
		///</summary>
		public void Set_BlockColor(dynamic color) 
		{
			this._i.BlockColor = color;
		}

		///<summary>
		///
		///</summary>
		public bool EnableBlockScale => this._i.EnableBlockScale;

		///<summary>
		///
		///</summary>
		public void Set_EnableBlockScale(bool enabled) 
		{
			this._i.EnableBlockScale = enabled;
		}

		///<summary>
		///
		///</summary>
		public double BlockScale => this._i.BlockScale;

		///<summary>
		///
		///</summary>
		public void Set_BlockScale(double ScaleFactor) 
		{
			this._i.BlockScale = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public bool EnableBlockRotation => this._i.EnableBlockRotation;

		///<summary>
		///
		///</summary>
		public void Set_EnableBlockRotation(bool enabled) 
		{
			this._i.EnableBlockRotation = enabled;
		}

		///<summary>
		///
		///</summary>
		public double BlockRotation => this._i.BlockRotation;

		///<summary>
		///
		///</summary>
		public void Set_BlockRotation(double Rotation) 
		{
			this._i.BlockRotation = Rotation;
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
		public bool OverwritePropChanged => this._i.OverwritePropChanged;

		///<summary>
		///
		///</summary>
		public bool Annotative => this._i.Annotative;

		///<summary>
		///
		///</summary>
		public void Set_Annotative(bool Annotative) 
		{
			this._i.Annotative = Annotative;
		}

		///<summary>
		///
		///</summary>
		public double BreakSize => this._i.BreakSize;

		///<summary>
		///
		///</summary>
		public void Set_BreakSize(double size) 
		{
			this._i.BreakSize = size;
		}

		///<summary>
		///
		///</summary>
		public string TextString => this._i.TextString;

		///<summary>
		///
		///</summary>
		public void Set_TextString(string Text) 
		{
			this._i.TextString = Text;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextAngleType => this._i.TextAngleType;

		///<summary>
		///
		///</summary>
		public void Set_TextAngleType(AXDBLib.AcTextAngleType Type) 
		{
			this._i.TextAngleType = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextAlignmentType => this._i.TextAlignmentType;

		///<summary>
		///
		///</summary>
		public void Set_TextAlignmentType(AXDBLib.AcTextAlignmentType Type) 
		{
			this._i.TextAlignmentType = Type;
		}
	}
}
