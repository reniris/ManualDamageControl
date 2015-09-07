using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;

namespace ManualDamageControl.Models
{
	public class ItemModel : NotificationObject
	{
		/*
		 * NotificationObjectはプロパティ変更通知の仕組みを実装したオブジェクトです。
		 */

		private const string NO_DAMAGECONTROL = "ダメコンなし";
		private const string PUT_DAMAGECONTROL = "帰投したらダメコン付け直せ";
		private const string EQUIP_DAMAGECONTROL = "ダメコンが発動したらクリック";


		#region HasDamageControl変更通知プロパティ
		private bool _HasDamageControl;

		public bool HasDamageControl
		{
			get
			{ return _HasDamageControl; }
			set
			{
				if (_HasDamageControl == value)
					return;
				_HasDamageControl = value;
				RaisePropertyChanged("HasDamageControl");

				if (value == true)
					this.IsDamageControl = false;
				else
					this.IsDamageControl = null;
			}
		}
		#endregion


		#region IsDamageControl変更通知プロパティ
		private bool? _IsDamageControl;

		public bool? IsDamageControl
		{
			get
			{ return _IsDamageControl; }
			set
			{
				if (_IsDamageControl == value)
					return;
				_IsDamageControl = value;
				RaisePropertyChanged("IsDamageControl");

				if (value == true)
					this.DisplayText = PUT_DAMAGECONTROL;
				else if (value == false)
					this.DisplayText = EQUIP_DAMAGECONTROL;
				else
					this.DisplayText = NO_DAMAGECONTROL;
			}
		}
		#endregion


		#region DisplayText変更通知プロパティ
		private string _DisplayText = NO_DAMAGECONTROL;

		public string DisplayText
		{
			get
			{ return _DisplayText; }
			set
			{
				if (_DisplayText == value)
					return;
				_DisplayText = value;
				RaisePropertyChanged("DisplayText");
			}
		}
		#endregion

	}
}
