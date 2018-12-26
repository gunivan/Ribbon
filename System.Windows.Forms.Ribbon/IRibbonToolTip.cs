using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace System.Windows.Forms
{
	interface IRibbonToolTip
	{
		/// <summary>
		/// Gets or Sets the ToolTip Text
		/// </summary>
		string ToolTip { get; set; }
		/// <summary>
		/// Gets or Sets the ToolTip Title
		/// </summary>
		string ToolTipTitle { get; set; }
		/// <summary>
		/// Gets or Sets the ToolTip Image
		/// </summary>
		Image ToolTipImage { get; set; }
		/// <summary>
		/// Gets or Sets the stock ToolTip Icon
		/// </summary>
		ToolTipIcon ToolTipIcon { get; set; }
	}

}
