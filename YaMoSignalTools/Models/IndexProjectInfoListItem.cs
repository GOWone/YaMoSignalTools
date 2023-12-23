using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaMoSignalTools.Models
{
    public class IndexProjectInfoListItem
    {
		private int order;

		public int Order
		{
			get { return order; }
			set { order = value; }
		}

		private string projectName;

		public string ProjectName
		{
			get { return projectName; }
			set { projectName = value; }
		}

		private string projectType;

		public string ProjectType
		{
			get { return projectType; }
			set { projectType = value; }
		}


		private string updateTime;

		public string UpdateTime
		{
			get { return updateTime; }
			set { updateTime = value; }
		}

	}
}
