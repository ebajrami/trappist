﻿using Promact.Trappist.DomainModel.Models.Question;
using System.Collections.Generic;

namespace Promact.Trappist.DomainModel.ApplicationClasses
{
    public class SingleMultipleQuestionAC
    {
        public SingleMultipleAnswerQuestion SingleMultipleAnswerQuestion { get; set; }
        public List<SingleMultipleAnswerQuestionOption> SingleMultipleAnswerQuestionOption { get; set; }
    }
}
