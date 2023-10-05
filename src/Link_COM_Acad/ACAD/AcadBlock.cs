using Autodesk.DesignScript.Geometry;
using System.CodeDom;
using System.Collections.Generic;
using dg = Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    ///A block definition containing a name and a set of objects. There are four types of blocks: the simple block, the XRef block, the layout block, and the dynamic block
    ///</summary>
    public class AcadBlock 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadBlock _i;
		internal AcadBlock(object AcadBlock_object) 
		{
			this._i = AcadBlock_object as Autodesk.AutoCAD.Interop.Common.AcadBlock;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///
        ///</summary>
        public AcadBlock (AcadBlocks AcadBlocks, Point InsertionPoint, string Name)
        {
           this._i = AcadBlocks._i.Add(Technical.PointByDynPoint(InsertionPoint), Name);
        }
        ///<summary>
        /// Gets the member object at a given index in a collection, group, or selection set
        ///</summary>
        private AcadEntity Item(object Index) 
		{
			return new AcadEntity( this._i.Item(Index));
		}
		/// <summary>
		/// Getting all objects at that block
		/// </summary>
		/// <returns></returns>
		public List<AcadEntity> GetObjects()
		{
			List<AcadEntity> es = new List<AcadEntity>();
			foreach (var ent in this._i)
			{
				es.Add(new AcadEntity(ent));
			}
			return es;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

        ///<summary>
        ///Specifies the name of the object
        ///</summary>
        public string Name => this._i.Name;

        ///<summary>
        ///Specifies the name of the object
        ///</summary>
        public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}

        ///<summary>
        ///Specifies the origin of block in WCS coordinates
        ///</summary>
        public Point Origin => Technical.PointByDoubleArray(this._i.Origin);

        ///<summary>
        ///Specifies the origin of block in WCS coordinates
        ///</summary>
        public void Set_Origin(Point Origin) 
		{
			this._i.Origin = Technical.PointByDynPoint(Origin);
		}

        /// <summary>
        /// Creates a custom object. The ObjectARX DLL defining the rxClassName custom class must be loaded. Use the LoadARX method on the Application object to explicitly load the ObjectARX file
        /// </summary>
        /// <param name="ClassName">The rxClassName must be defined in an ObjectARX® application (ObjectARX DLL) or the method will fail</param>
        /// <returns>The newly created Custom object</returns>
        public AcadEntity AddCustomObject(string ClassName) 
		{
			return new AcadEntity(this._i.AddCustomObject(ClassName));
		}



        ///<summary>
        ///Determines whether the given block is a layout block
        ///</summary>
        public bool IsLayout => this._i.IsLayout;

        ///<summary>
        ///Specifies the layout associated with the model space, paper space, or block object
        ///</summary>
        public AcadLayout Layout => new AcadLayout(this._i.Layout);

        ///<summary>
        ///Determines whether the given block is an XRef block
        ///</summary>
        public bool IsXRef => this._i.IsXRef;

        ///<summary>
        ///Gets the Database object that defines the contents of the block
        ///</summary>
        public AcadDatabase XRefDatabase => new AcadDatabase(this._i.XRefDatabase);


        ///<summary>
        ///Unloads the menu group or external reference
        ///</summary>
        public void Unload()
		{
			this._i.Unload();
		}

        ///<summary>
        ///Reloads the external reference (xref)
        ///</summary>
        public void Reload()
		{
			this._i.Reload();
		}

        ///<summary>
        ///Binds an external reference (xref) to a drawing. Binding an xref to a drawing makes the xref a permanent part of the drawing and no longer an externally referenced file. The externally referenced information becomes a block. When the externally referenced drawing is updated, the bound xref is not updated. This method binds the entire drawing's database, including all of its dependent symbols. Dependent symbols are named objects such as blocks, dimension styles, layers, linetypes, and text styles. Binding the xref allows named objects from the xref to be used in the current drawing.
        ///</summary>
        public void Bind(bool bPrefixName)
		{
			this._i.Bind(bPrefixName);
		}

        ///<summary>
        ///Detaches an external reference (xref) from a drawing. Detaching an xref removes the xref from the current drawing. All copies of the xref are erased, and the xref definition is deleted. All xref-dependent symbol table information (such as layers and linetypes) is deleted from the current drawing
        ///</summary>
        public void Detach()
		{
			this._i.Detach();
		}

        ///<summary>
        ///Gets the path of the block, document, application, or external reference
        ///</summary>
        public string Path => this._i.Path;

        ///<summary>
        ///Gets the path of the block, document, application, or external reference
        ///</summary>
        public void Set_Path(string bstrName)
		{
			this._i.Path = bstrName;
		}

        ///<summary>
        ///Specifies the comments for the block or drawing
        ///</summary>
        public string Comments => this._i.Comments;

        ///<summary>
        ///Specifies the comments for the block or drawing
        ///</summary>
        public void Set_Comments(string bstrName)
		{
			this._i.Comments = bstrName;
		}

        ///<summary>
        ///Specifies the native units of measure for the block
        ///</summary>
        public object Units => this._i.Units;

        ///<summary>
        ///Specifies the native units of measure for the block
        ///</summary>
        public void Set_Units(Autodesk.AutoCAD.Interop.Common.AcInsertUnits pIU)
		{
			this._i.Units = pIU;
		}

        ///<summary>
        ///Specifies whether the block can be exploded
        ///</summary>
        public bool Explodable => this._i.Explodable;

        ///<summary>
        ///Specifies whether the block can be exploded
        ///</summary>
        public void Set_Explodable(bool bExplodable)
		{
			this._i.Explodable = bExplodable;
		}

        ///<summary>
        ///Specifies the scaling allowed for the block
        ///</summary>
        public object BlockScaling => this._i.BlockScaling;

        ///<summary>
        ///Specifies the scaling allowed for the block
        ///</summary>
        public void Set_BlockScaling(Autodesk.AutoCAD.Interop.Common.AcBlockScaling pBS)
		{
			this._i.BlockScaling = pBS;
		}

        ///<summary>
        ///Specifies whether this is a dynamic block
        ///</summary>
        public bool IsDynamicBlock => this._i.IsDynamicBlock;

		

		
	}
}
