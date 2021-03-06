using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835606.aspx </remarks>
	[SupportByVersionAttribute("Excel", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDataBarNegativeColorType
	{
		 /// <summary>
		 /// SupportByVersion Excel 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 14,15,16)]
		 xlDataBarColor = 0,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 14,15,16)]
		 xlDataBarSameAsPositive = 1
	}
}