﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConection
    {
        private const string PrizesFile = "PrizeModels.csv";
        // TODO -Wire up the CreatePrize to text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;
               if (prizes.Count>0)
            {
                currentId = prizes.OrderByDescending(p => p.Id).First().Id + 1;
            }             
            model.Id = currentId;
            prizes.Add(model);
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}
