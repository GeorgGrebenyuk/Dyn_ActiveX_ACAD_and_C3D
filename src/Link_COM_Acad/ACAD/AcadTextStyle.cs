using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
        /// Get existed style or create new style
        ///</summary>
        public AcadTextStyle (AcadTextStyles AcadTextStyles, string styleName)
        {
            for (int i = 0; i < AcadTextStyles._i.Count; i++)
            {
                var style = AcadTextStyles._i.Item(i);
				if (style.Name == styleName) this._i = style;
            }
            this._i = AcadTextStyles._i.Add(styleName);
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
		public double ObliqueAngle => this._i.ObliqueAngle;

		///<summary>
		///
		///</summary>
		public void Set_ObliqueAngle(double obliAngle) 
		{
			this._i.ObliqueAngle = obliAngle;
		}

		///<summary>
		///
		///</summary>
		public int TextGenerationFlag => this._i.TextGenerationFlag;

		///<summary>
		///
		///</summary>
		public void Set_TextGenerationFlag(int textGenFlag) 
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
