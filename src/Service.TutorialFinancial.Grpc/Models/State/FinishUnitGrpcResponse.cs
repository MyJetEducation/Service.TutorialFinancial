﻿using System.Runtime.Serialization;
using Service.Core.Client.Constants;

namespace Service.TutorialFinancial.Grpc.Models.State
{
	[DataContract]
	public class FinishUnitGrpcResponse
	{
		[DataMember(Order = 1)]
		public FinancialStateUnitGrpcModel Unit { get; set; }

		[DataMember(Order = 2)]
		public int TrueFalseProgress { get; set; }

		[DataMember(Order = 3)]
		public int CaseProgress { get; set; }

		[DataMember(Order = 4)]
		public UserAchievement[] NewAchievements { get; set; }
	}
}