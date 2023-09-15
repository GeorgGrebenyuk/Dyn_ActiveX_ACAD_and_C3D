using Autodesk.DesignScript.Geometry;
using System.CodeDom;
using System.Collections.Generic;
using dg = Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
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
        ///
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
		///
		///</summary>
		public object Origin => this._i.Origin;

		///<summary>
		///
		///</summary>
		public void Set_Origin(object Origin) 
		{
			this._i.Origin = Origin;
		}

		///<summary>
		//
		///</summary>
		public AcadEntity AddCustomObject(string ClassName) 
		{
			return new AcadEntity(this._i.AddCustomObject(ClassName));
		}


		
		///<summary>
		///
		///</summary>
		public bool IsLayout => this._i.IsLayout;

		///<summary>
		///
		///</summary>
		public AcadLayout Layout => new AcadLayout(this._i.Layout);

		///<summary>
		///
		///</summary>
		public bool IsXRef => this._i.IsXRef;

		/////<summary>
		/////
		/////</summary>
		//public dynamic AddMInsertBlock(object InsertionPoint, string Name, double Xscale, double Yscale, double Zscale, double Rotation, dynamic NumRows, dynamic NumColumns, dynamic RowSpacing, dynamic ColumnSpacing, object Password)
		//{
		//	return this._i.AddMInsertBlock(InsertionPoint, Name, Xscale, Yscale, Zscale, Rotation, NumRows, NumColumns, RowSpacing, ColumnSpacing, Password);
		//}

		

		


		///<summary>
		///
		///</summary>
		public dynamic XRefDatabase => this._i.XRefDatabase;

		

		///<summary>
		///
		///</summary>
		public void Unload()
		{
			this._i.Unload();
		}

		///<summary>
		///
		///</summary>
		public void Reload()
		{
			this._i.Reload();
		}

		///<summary>
		///
		///</summary>
		public void Bind(bool bPrefixName)
		{
			this._i.Bind(bPrefixName);
		}

		///<summary>
		///
		///</summary>
		public void Detach()
		{
			this._i.Detach();
		}

		

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public void Set_Path(string bstrName)
		{
			this._i.Path = bstrName;
		}

		///<summary>
		///
		///</summary>
		public string Comments => this._i.Comments;

		///<summary>
		///
		///</summary>
		public void Set_Comments(string bstrName)
		{
			this._i.Comments = bstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic Units => this._i.Units;

		///<summary>
		///
		///</summary>
		public void Set_Units(Autodesk.AutoCAD.Interop.Common.AcInsertUnits pIU)
		{
			this._i.Units = pIU;
		}

		///<summary>
		///
		///</summary>
		public bool Explodable => this._i.Explodable;

		///<summary>
		///
		///</summary>
		public void Set_Explodable(bool bExplodable)
		{
			this._i.Explodable = bExplodable;
		}

		///<summary>
		///
		///</summary>
		public dynamic BlockScaling => this._i.BlockScaling;

		///<summary>
		///
		///</summary>
		public void Set_BlockScaling(Autodesk.AutoCAD.Interop.Common.AcBlockScaling pBS)
		{
			this._i.BlockScaling = pBS;
		}

		///<summary>
		///
		///</summary>
		public bool IsDynamicBlock => this._i.IsDynamicBlock;

		

		
	}
}
