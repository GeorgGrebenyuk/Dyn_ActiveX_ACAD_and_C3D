namespace DynAXDBLib 
{

    ///<summary>
    /// A surface entity. This object provides access to surfaces in AutoCAD. It lets you manipulate properties of the surface. You cannot create a surface entity via ActiveX
    ///</summary>
    public class AcadSurface 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSurface _i;
		internal AcadSurface(object AcadSurface_object) 
		{
			this._i = AcadSurface_object as Autodesk.AutoCAD.Interop.Common.AcadSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadSurface(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadSurface;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        /// Indicates the type of surface
        ///</summary>
        public string SurfaceType => this._i.SurfaceType;

        ///<summary>
        /// Specifies the number of U isolines that are displayed
        ///</summary>
        public int UIsolineDensity => this._i.UIsolineDensity;

        ///<summary>
        /// Specifies the number of U isolines that are displayed
        ///</summary>
        public void Set_UIsolineDensity(int density) 
		{
			this._i.UIsolineDensity = density;
		}

        ///<summary>
        /// Specifies the number of V isolines that are displayed
        ///</summary>
        public int VIsolineDensity => this._i.VIsolineDensity;

        ///<summary>
        /// Specifies the number of V isolines that are displayed
        ///</summary>
        public void Set_VIsolineDensity(int density) 
		{
			this._i.VIsolineDensity = density;
		}

        ///<summary>
        ///Specifies the wireframe display type of the surface
        ///</summary>
        public object WireframeType => this._i.WireframeType;

        ///<summary>
        ///Specifies the wireframe display type of the surface
        ///</summary>
        public void Set_WireframeType(Autodesk.AutoCAD.Interop.Common.AcWireframeType Type) 
		{
			this._i.WireframeType = Type;
		}

        ///<summary>
        ///Specifies if a surface maintains its associativity with another surface
        ///</summary>
        public int MaintainAssociativity => this._i.MaintainAssociativity;

        ///<summary>
        ///Specifies if a surface maintains its associativity with another surface
        ///</summary>
        public void Set_MaintainAssociativity(int maintainAssoc) 
		{
			this._i.MaintainAssociativity = maintainAssoc;
		}

        ///<summary>
        ///Specifies if dependent surfaces are highlighted when the surface is selected
        ///</summary>
        public bool ShowAssociativity => this._i.ShowAssociativity;

        ///<summary>
        ///Specifies if dependent surfaces are highlighted when the surface is selected
        ///</summary>
        public void Set_ShowAssociativity(bool bEnabled) 
		{
			this._i.ShowAssociativity = bEnabled;
		}

        ///<summary>
        ///Specifies the distance by which the edges of surface are extended to merge to an existing surface
        ///</summary>
        public object EdgeExtensionDistances => this._i.EdgeExtensionDistances;

        ///<summary>
        ///Specifies the distance by which the edges of surface are extended to merge to an existing surface
        ///</summary>
        public void Set_EdgeExtensionDistances(object extDistances) 
		{
			this._i.EdgeExtensionDistances = extDistances;
		}

        ///<summary>
        ///Specifies if associativity is maintained between the surface and the objects used to trim the object
        ///</summary>
        public object SurfTrimAssociativity => this._i.SurfTrimAssociativity;

        /// <summary>
        /// Specifies if associativity is maintained between the surface and the objects used to trim the object
        /// </summary>
        /// <param name="associative">True: Associativity is maintained between the surface and the trim objects; False: Associativity is not maintained between the surface and the trim objects</param>
        public void Set_SurfTrimAssociativity(object associative) 
		{
			this._i.SurfTrimAssociativity = associative;
		}
	}
}
