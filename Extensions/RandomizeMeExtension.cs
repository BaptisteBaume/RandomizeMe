//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:26:19

namespace Bb.RandomizeMe.Core.Extensions
{
    public static class RandomizeMeExtension
    {
        #region Methods

        /// <summary>
        /// Renvoie un integer en string avec un 0 devant pour les chiffres inférieurs 10
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string StringifyInterger(this int number)
        {
            if (number < 10)
                return '0' + number.ToString();
            return number.ToString();
        }

        #endregion
    }
}
