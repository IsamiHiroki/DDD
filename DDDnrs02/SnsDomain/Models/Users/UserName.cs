﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Users
{
	class UserName
	{
		public UserName(string value)
		{
			if (value == null) throw new ArgumentNullException(nameof(value));
			if (value.Length < 3) throw new ArgumentException("ユーザ名は3文字以上です。", nameof(value));
			if (value.Length > 20) throw new ArgumentException("ユーザ名は20文字以下です。", nameof(value));

			Value = value;
		}

		public string Value { get; }
	}

}
