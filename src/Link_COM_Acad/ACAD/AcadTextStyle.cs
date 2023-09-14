using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadTextStyle 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadTextStyle _i;
		internal AcadTextStyle(object AcadTextStyle_object) 
		{
			this._i = AcadTextStyle_object as Autodesk.AutoCAD.Interop.Common.AcadTextStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        ///
        ///</summary>
        public AcadTextStyle (AcadTextStyles AcadTextStyles, string Name)
        {
            this._i = AcadTextStyles._i.Add(Name);
        }

        ///<summary>
        ///
        ///</summary>
        public string BigFontFile => this._i.BigFontFile;

		///<summary>
		///
		///</summary>
		public void Set_BigFontFile(string fontFile) 
		{
			this._i.BigFontFile = fontFile;
		}

		///<summary>
		///
		///</summary>
		public string fontFile => this._i.fontFile;

		///<summary>
		///
		///</summary>
		public void Set_fontFile(string fontFile) 
		{
			this._i.fontFile = fontFile;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

		///<summary>
		///
		///</summary>
		public double LastHeight => this._i.LastHeight;

		///<summary>
		///
		///</summary>
		public void Set_LastHeight(double Height) 
		{
			this._i.LastHeight = Height;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public dynamic ObliqueAngle => this._i.ObliqueAngle;

		///<summary>
		///
		///</summary>
		public void Set_ObliqueAngle(dynamic obliAngle) 
		{
			this._i.ObliqueAngle = obliAngle;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextGenerationFlag => this._i.TextGenerationFlag;

		///<summary>
		///
		///</summary>
		public void Set_TextGenerationFlag(dynamic textGenFlag) 
		{
			this._i.TextGenerationFlag = textGenFlag;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double Width) 
		{
			this._i.Width = Width;
		}

		///<summary>
		///
		///</summary>
		public List<object> GetFont()
        {
			string TypeFace;
            bool Bold;
			bool Italic;
			int Charset;
            int PitchAndFamily;

            this._i.GetFont(out TypeFace,out Bold,out Italic,out Charset,out PitchAndFamily);
			return new List<object> { TypeFace, Bold, Italic, Charset, PitchAndFamily };
		}

		///<summary>
		///
		///</summary>
		public void SetFont(string TypeFace,bool Bold,bool Italic,dynamic Charset,dynamic PitchAndFamily) 
		{
			this._i.SetFont(TypeFace,Bold,Italic,Charset,PitchAndFamily);
		}
	}
}
