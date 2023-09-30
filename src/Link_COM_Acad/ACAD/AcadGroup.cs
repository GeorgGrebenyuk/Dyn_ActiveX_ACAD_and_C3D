using System.Collections.Generic;
using System.Linq;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGroup 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadGroup _i;
		internal AcadGroup(object AcadGroup_object) 
		{
			this._i = AcadGroup_object as Autodesk.AutoCAD.Interop.Common.AcadGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        ///Create new group
        ///</summary>
        public AcadGroup (AcadGroups AcadGroups, string Name)
        {
            this._i = AcadGroups._i.Add(Name);
        }
        ///<summary>
        ///
        ///</summary>
        private AcadEntity Item(object Index) 
		{
			return new AcadEntity(this._i.Item(Index));
		}
		/// <summary>
		/// Get all entities from that group
		/// </summary>
		/// <returns></returns>
		public List<AcadEntity> GetEntities()
		{
			List<AcadEntity> ents = new List<AcadEntity>();
			foreach (var e in this._i)
			{
				ents.Add(new AcadEntity(e));
            }
			return ents;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

		///<summary>
		///0x00020120
		///</summary>
		public void Set_TrueColor(dynamic rhs) 
		{
			this._i.TrueColor = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Layer(string rhs) 
		{
			this._i.Layer = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Linetype(string rhs) 
		{
			this._i.Linetype = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_LinetypeScale(dynamic rhs) 
		{
			this._i.LinetypeScale = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Visible(bool rhs) 
		{
			this._i.Visible = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Highlight(bool HighlightFlag) 
		{
			this._i.Highlight(HighlightFlag);
		}

		///<summary>
		///
		///</summary>
		public void Set_PlotStyleName(string rhs) 
		{
			this._i.PlotStyleName = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_Lineweight(dynamic rhs) 
		{
			this._i.Lineweight = rhs;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public void AppendItems(List<AcadEntity> Objects) 
		{
			this._i.AppendItems(Objects.Select(a=>a._i).ToArray());
		}

		///<summary>
		///
		///</summary>
		public void RemoveItems(List<AcadEntity> Objects) 
		{
			this._i.RemoveItems(Objects.Select(a => a._i).ToArray());
		}

		///<summary>
		///
		///</summary>
		public void Update() 
		{
			this._i.Update();
		}

		///<summary>
		///
		///</summary>
		public void Set_Material(string rhs) 
		{
			this._i.Material = rhs;
		}

		///<summary>
		///
		///</summary>
		public void Set_color(Autodesk.AutoCAD.Interop.Common.AcColor rhs) 
		{
			this._i.color = rhs;
		}
	}
}
