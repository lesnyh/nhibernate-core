// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class TypeAttribute : BaseAttribute
	{
		
		private string _name = null;
		
		/// <summary> Default constructor (position=0) </summary>
		public TypeAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public TypeAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type NameType
		{
			get
			{
				return System.Type.GetType( this.Name );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Name = value.FullName.Substring(7);
				else
					this.Name = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
	}
}
