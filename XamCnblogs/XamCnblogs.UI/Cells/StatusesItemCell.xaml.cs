﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamCnblogs.UI.Cells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatusesItemCell : ContentView
	{
		public StatusesItemCell ()
		{
			InitializeComponent ();
		}
	}
}