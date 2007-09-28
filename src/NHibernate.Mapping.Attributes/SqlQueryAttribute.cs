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
	public class SqlQueryAttribute : BaseAttribute
	{
		
		private string _name = null;
		
		private string _content = null;
		
		private string _resultsetref = null;
		
		private FlushMode _flushmode = FlushMode.Unspecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public SqlQueryAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public SqlQueryAttribute(int position) : 
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
		public virtual string ResultSetRef
		{
			get
			{
				return this._resultsetref;
			}
			set
			{
				this._resultsetref = value;
			}
		}
		
		/// <summary> </summary>
		public virtual FlushMode FlushMode
		{
			get
			{
				return this._flushmode;
			}
			set
			{
				this._flushmode = value;
			}
		}
		
		/// <summary> Gets or sets the content of this element </summary>
		public virtual string Content
		{
			get
			{
				return this._content;
			}
			set
			{
				this._content = value;
			}
		}
	}
}
