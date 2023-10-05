using Autodesk.DesignScript.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

    ///<summary>
    /// An instance of a block definition inserted into a drawing
    ///</summary>
    public class AcadBlockReference 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadBlockReference _i;
		/// <summary>
		/// Use only with py-script
		/// </summary>
		/// <param name="AcadBlockReference_object"></param>
		/// <exception cref="System.Exception"></exception>
        public AcadBlockReference(object AcadBlockReference_object) 
		{
			this._i = AcadBlockReference_object as Autodesk.AutoCAD.Interop.Common.AcadBlockReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadBlockReference(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadBlockReference;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }


        /// <summary>
        /// Inserts a drawing file or a named block that has been defined in the current drawing
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="InsertionPoint">The 3D WCS coordinates specifying the location in the drawing to insert the block</param>
        /// <param name="Name">The name of the AutoCAD drawing file or the name of the block to insert. If it is a file name, include the .dwg extension and any path information necessary for AutoCAD to find the file</param>
        /// <param name="Xscale">The default equals 1.0. Must be a positive number</param>
        /// <param name="Yscale">The default equals 1.0. Must be a positive number</param>
        /// <param name="Zscale">The default equals 1.0. Must be a positive number</param>
        /// <param name="Rotation">The default equals 0.0 radians</param>
        public AcadBlockReference (dynamic AcadBlock, Point InsertionPoint, string Name,
			double Xscale, double Yscale, double Zscale, double Rotation)
		{
            this._i = AcadBlock._i.InsertBlock(Technical.PointByDynPoint(InsertionPoint),
                    Name, Xscale, Yscale, Zscale, Rotation);
        }

		///<summary>
		///
		///</summary>
		public Point InsertionPoint => Technical.PointByDoubleArray(this._i.InsertionPoint);

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(object insPoint) 
		{
			this._i.InsertionPoint = insPoint;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
        }

        ///<summary>
        ///
        ///</summary>
        public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public double XScaleFactor => this._i.XScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_XScaleFactor(double ScaleFactor) 
		{
			this._i.XScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double YScaleFactor => this._i.YScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_YScaleFactor(double ScaleFactor) 
		{
			this._i.YScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double ZScaleFactor => this._i.ZScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ZScaleFactor(double ScaleFactor) 
		{
			this._i.ZScaleFactor = ScaleFactor;
		}

        ///<summary>
        /// Get new AcadEntitis as result of that object exploding
        ///</summary>
        public List<AcadEntity> Explode => Technical.GetParts(this._i.Explode());

        ///<summary>
        ///
        ///</summary>
        public List<AcadAttributeReference> GetAttributes() => ((System.Array)this._i.GetAttributes()).
			Cast<object>().Select(a=> new AcadAttributeReference(a)).ToList();

		///<summary>
		///
		///</summary>
		public List<AcadAttributeReference> GetConstantAttributes() => ((System.Array)this._i.GetConstantAttributes()).
            Cast<object>().Select(a => new AcadAttributeReference(a)).ToList();

        ///<summary>
        /// Specifies whether the block has any attributes in it
        ///</summary>
        public bool HasAttributes => this._i.HasAttributes;

        ///<summary>
        /// Specifies the original block name
        ///</summary>
        public string EffectiveName => this._i.EffectiveName;

        ///<summary>
        /// Specifies whether this is a dynamic block
        ///</summary>
        public bool IsDynamicBlock => this._i.IsDynamicBlock;

        ///<summary>
        /// Gets the properties of the dynamic block
        ///</summary>
        public List<AcadDynamicBlockReferenceProperty> GetDynamicBlockProperties => ((System.Array)this._i.GetDynamicBlockProperties()).
            Cast<object>().Select(a => new AcadDynamicBlockReferenceProperty(a)).ToList();

        ///<summary>
        /// Resets the dynamic block to the default state
        ///</summary>
        public void ResetBlock() 
		{
			this._i.ResetBlock();
		}

        ///<summary>
        /// Converts a dynamic block to a regular anonymous block
        ///</summary>
        public void ConvertToAnonymousBlock() 
		{
			this._i.ConvertToAnonymousBlock();
		}

        ///<summary>
        /// Converts a dynamic block to a regular named block
        ///</summary>
        public void ConvertToStaticBlock(string newBlockName) 
		{
			this._i.ConvertToStaticBlock(newBlockName);
		}

		///<summary>
		///
		///</summary>
		public double XEffectiveScaleFactor => this._i.XEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_XEffectiveScaleFactor(double ScaleFactor) 
		{
			this._i.XEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double YEffectiveScaleFactor => this._i.YEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_YEffectiveScaleFactor(double ScaleFactor) 
		{
			this._i.YEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public double ZEffectiveScaleFactor => this._i.ZEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ZEffectiveScaleFactor(double ScaleFactor) 
		{
			this._i.ZEffectiveScaleFactor = ScaleFactor;
		}

        ///<summary>
        /// Specifies the insert units saved with the block. The InsUnits property specifies the native units for the block reference as defined by the block author. When a block is inserted in a drawing whose units have been defined, the block is automatically scaled proportional to the InsUnitsFactor, the conversion factor between the block units and the current drawing units
        ///</summary>
        public string InsUnits => this._i.InsUnits;

        ///<summary>
        /// Specifies the conversion factor between block units and drawing units. The conversion factor between block and drawing units
        ///</summary>
        public double InsUnitsFactor => this._i.InsUnitsFactor;
	}
}
