using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FairShare
{
	public partial class FairShareForm : Form
	{
		public FairShareForm()
		{
			InitializeComponent();
			ResetMappings();
			ResetMappings();
			ResetResults();
		}

		private void ResetMappings()
		{
			foreach (Control control in tlpMappings.Controls)
			{
				control.Dispose();
			}
			tlpMappings.Controls.Clear();
			tlpMappings.RowCount = 0;
			tlpMappings.ColumnCount = 1;
		}

		private void ResetResults()
		{
			chkResults.Items.Clear();
			cachedResults = string.Empty;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			ResetResults();
			cachedResults = FairShare.Get((int)numGroups.Value, (int)numPicks.Value);

			// preserves mappings if the number of groups didn't change
			if ((int)numGroups.Value != tlpMappings.Controls.Count)
			{
				ResetMappings();

				// populate mapping list
				foreach (var v in cachedResults.Distinct())
				{
					var tb = new TextBox();
					tb.TextChanged += (o, t) => { mappings[v] = tb.Text; };
					tb.Text = v.ToString();
					tlpMappings.Controls.Add(tb, 0, tlpMappings.RowCount);
					tlpMappings.RowCount++;
				}
			}

			MapResults();

			// need to add this event post-MapResults(), since MapResults changed Text, and this event called MapResults()
			foreach (Control c in tlpMappings.Controls)
			{
				c.TextChanged += (o, t) => { MapResults(); };
			}
		}

		string cachedResults;
		Dictionary<char, string> mappings = new Dictionary<char, string>();

		private void MapResults()
		{
			chkResults.Items.Clear();
			// populate results list
			foreach (var v in cachedResults)
			{
				chkResults.Items.Add(mappings[v]);
			}
		}
	}
}
