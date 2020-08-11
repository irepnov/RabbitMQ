using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3.Sormo
{
	/// <summary>
	/// Контракт для сервиса СОРМО уведомляющий о новом случая случае обслуживания в ИЭМК
	/// </summary>
	public class SormoNewCaseContract
	{
		/// <summary>
		/// Идентификатор случая обслуживания
		/// </summary>
		public int CaseId { get; set; }

		/// <summary>
		/// Тип случая обслуживания
		/// </summary>
		public int CaseTypeId { get; set; }

		/// <summary>
		/// Идентификатор медецинского учререждения
		/// </summary>
		public string LpuId { get; set; }
		/// <summary>
		/// Дата закрытия случая обслуживания
		/// </summary>
		public DateTime CloseDate { get; set; }

		/// <summary>
		/// Идентификатор пациента
		/// </summary>
		public string PatientId { get; set; }

		/// <summary>
		/// Код диагноза
		/// </summary>
		public string Diagnosis { get; set; }

		#region Overrides of Object

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("SormoNewCaseContract");
			sb.AppendLine($"Идентификатор случая обслуживания (CaseId):'{CaseId}'");
			sb.AppendLine($"Тип случая обслуживания (CaseTypeId):'{CaseTypeId}'");
			sb.AppendLine($"Идентификатор медецинского учререждения (LpuId):'{LpuId}'");
			sb.AppendLine($"Идентификатор пациента (PatientId):'{PatientId}'");
			sb.AppendLine($"Код диагноза (Diagnosis):'{Diagnosis}'");
			return sb.ToString();
		}

		#endregion
	}

	public class MessageTextContract
	{
		public string Message { get; set; }

		#region Overrides of Object

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("MessageTextContract");
			sb.AppendLine($"Сообщение (Message):'{Message}'");
			return sb.ToString();

		}

		#endregion
	}



}

namespace N3.DliFed
{

	public class DliFedNewResult
	{
		public string OrderResponceId { get; set; }
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("MessageTextContract");
			sb.AppendLine($"Сообщение (OrderResponceId):'{OrderResponceId}'");
			return sb.ToString();

		}
	}

	public class DliMsgNewResult
	{
		public string DiagnosticReportId { get; set; }
		public string PatientId { get; set; }
		public string DiagnosticReportCode { get; set; }

		public List<DliMsgNewResult.TestCode> TestCodes { get; set; }

		public class TestCode
		{
			public string Code { get; set; }
			public string InterpretationCode { get; set; }
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("MessageTextContract");
			sb.AppendLine($"DiagnosticReportId:'{DiagnosticReportId}'");
			sb.AppendLine($"PatientId:'{PatientId}'");
			sb.AppendLine($"DiagnosticReportCode:'{DiagnosticReportCode}'");
			sb.AppendLine($"TestCodes:");
			if (TestCodes != null && TestCodes.Any())
			{
				sb.AppendLine($"[");
				foreach (var testCode in TestCodes)
				{
					sb.AppendLine($"Code:'{testCode.Code}, InterpretationCode:'{testCode.InterpretationCode}'");

				}
				sb.AppendLine($"]");
			}



			return sb.ToString();

		}
	}
}