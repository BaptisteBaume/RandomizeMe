//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:19:51

using Bb.RandomizeMe.Core.Dto.Exposed;
using Bb.RandomizeMe.Core.Interfaces.Business.Base;
using Bb.RandomizeMe.Core.Interfaces.Dto;

namespace Bb.RandomizeMe.Core.Interfaces.Business
{
    #region Interfaces

    interface IRandomizeMe : IBaseBusiness<IBusinessResult>
    {
        #region Methods

        BusinessResult<string> GetEmail(string firstName, string lastName, string separator = null, string domain = null, string extension = null, bool? direction = null);

        BusinessResult<string> GetRandomDateOfBirth(int minAge = 18, int maxAge = 75);

        /// <summary>
        /// Renvoie par défaut un n° de téléphone français commençant par 01, 02, 03, 04, 05, 06, 07 et séparé par des espaces
        /// </summary>
        /// <param name="separator"></param>
        /// <returns></returns>
        BusinessResult<string> GetRandomPhone(string separator = " ", string first = null);

        #endregion
    }

    #endregion
}
