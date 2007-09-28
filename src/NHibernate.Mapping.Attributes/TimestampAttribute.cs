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
	
	
	/// <summary>Is equivalent to &lt;version type="timestamp"&gt;</summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class TimestampAttribute : BaseAttribute
	{
		
		private string _column = null;
		
		private string _name = null;
		
		private string _unsavedvalue = null;
		
		private string _access = null;
		
		private VersionGeneration _generated = VersionGeneration.Unspecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public TimestampAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public TimestampAttribute(int position) : 
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
		public virtual string Access
		{
			get
			{
				return this._access;
			}
			set
			{
				this._access = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type AccessType
		{
			get
			{
				return System.Type.GetType( this.Access );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Access = value.FullName.Substring(7);
				else
					this.Access = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual string Column
		{
			get
			{
				return this._column;
			}
			set
			{
				this._column = value;
			}
		}
		
		/// <summary>undefined|any|none|null|0|-1|... </summary>
		public virtual string UnsavedValue
		{
			get
			{
				return this._unsavedvalue;
			}
			set
			{
				this._unsavedvalue = value;
			}
		}
		
		/// <summary>undefined|any|none|null|0|-1|... </summary>
		public virtual object UnsavedValueObject
		{
			get
			{
				return this.UnsavedValue;
			}
			set
			{
				this.UnsavedValue = value==null ? "null" : value.ToString();
			}
		}
		
		/// <summary> </summary>
		public virtual VersionGeneration Generated
		{
			get
			{
				return this._generated;
			}
			set
			{
				this._generated = value;
			}
		}
	}
}
