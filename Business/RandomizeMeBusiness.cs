//  ***************************************
//                                                   
//          Bb-RandomizeMe-Core
//                                                   
//  ***************************************
//  Baptiste Baume
//  Copyright (c) BbTech 2020 All Rights Reserved
//  17/04/2020 21:21:03

using Bb.RandomizeMe.Core.Business.Base;
using Bb.RandomizeMe.Core.Dto.Exposed;
using Bb.RandomizeMe.Core.Enumerations;
using Bb.RandomizeMe.Core.Extensions;
using Bb.RandomizeMe.Core.Interfaces.Business;
using System;
using System.Text;

namespace Bb.RandomizeMe.Core.Business
{
    internal class RandomizeMeBusiness : BaseBusiness, IRandomizeMe
    {
        #region Methods

        public BusinessResult<string> GetEmail(string firstName, string lastName, string separator = null, string domain = null, string extension = null, bool? direction = null)
        {
            Random random = new Random();
            string email = String.Empty;
            string sep = separator;
            string dom = domain;
            string ext = extension;


            if (string.IsNullOrEmpty(separator))
                sep = EmailAttributes.EMAIL_SEPARATORS[random.Next(EmailAttributes.EMAIL_SEPARATORS.Length)];

            if (string.IsNullOrEmpty(domain))
                dom = EmailAttributes.EMAIL_DOMAINS[random.Next(EmailAttributes.EMAIL_DOMAINS.Length)];

            if (string.IsNullOrEmpty(extension))
                ext = EmailAttributes.EMAIL_EXTENSIONS[random.Next(EmailAttributes.EMAIL_EXTENSIONS.Length)];

            int dir = 0;
            if (direction != null)
                dir = Convert.ToInt32(direction);
            else
                dir = random.Next(1);

            if (dir == 1)
                return new BusinessResult<string>(true, String.Format("{0}{1}{2}@{3}.{4}", firstName.ToLower(), sep, lastName.ToLower(), dom, ext));
            return new BusinessResult<string>(true, String.Format("{0}{1}{2}@{3}.{4}", lastName.ToLower(), sep, firstName.ToLower(), dom, ext));
        }

        public BusinessResult<string> GetRandomDateOfBirth(int minAge = 18, int maxAge = 75)
        {
            try
            {
                Random random = new Random();

                var today = DateTime.Now;
                var yearMax = today.AddYears(-maxAge).Year;
                var yearMin = today.AddYears(-minAge).Year;

                DateTime dateStart = new DateTime(yearMax, 1, 1);
                DateTime dateEnd = new DateTime(yearMin, 1, 1);

                int range = (dateEnd - dateStart).Days;

                return new BusinessResult<string>(true, today.AddDays(-random.Next(range)).ToString());
            }
            catch (Exception e)
            {
                return new BusinessResult<string>(true, String.Empty);
            }
        }

        public BusinessResult<string> GetRandomPhone(string separator = " ", string first = null)
        {
            try
            {
                Random random = new Random();
                StringBuilder stringBuilder = new StringBuilder();

                // premier numéro
                if (!string.IsNullOrEmpty(first))
                    stringBuilder.Append(first);
                else
                    stringBuilder.Append(PhoneCodes.PHONE_CODES[random.Next(0, PhoneCodes.PHONE_CODES.Length)]);

                stringBuilder.Append(separator);

                for (int i = 0; i < 4; i++)
                {
                    stringBuilder.Append(random.Next(0, 100).StringifyInterger());
                    if (i != 3)
                        stringBuilder.Append(separator);
                }
                return new BusinessResult<string>(true, stringBuilder.ToString());
            }
            catch (Exception)
            {
                return new BusinessResult<string>(false, null, "GetRandomPhone Error");
            }
        }

        #endregion
    }
}
