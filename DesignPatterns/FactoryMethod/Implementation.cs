﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Implementation
    {
        public abstract class DiscountService
        {
            public abstract int DiscountPercentage { get; }
            public override string ToString() => GetType().Name;
        }

        public abstract class DiscountFactory
        {
            public abstract DiscountService CreateDiscountService();
        }

        public class CountryDiscountService : DiscountService
        {
            private readonly string _countryIdentifier;

            public CountryDiscountService(string countryIdentifier)
            {
                _countryIdentifier = countryIdentifier;
            }

            public override int DiscountPercentage
            {
                get
                {
                    switch (_countryIdentifier)
                    {
                        case "BR":
                            return 99;
                        default:
                            return 10;
                    }
                }
            }
        }

        public class CodeDiscountService : DiscountService
        {
            private readonly Guid _code;

            public CodeDiscountService(Guid code)
            {
                _code = code;
            }

            public override int DiscountPercentage
            {
                // each code returns the same fixed percentage, but a code is only 
                // valid once - include a check to so whether the code's been used before
                // ... 
                get => 15;
            }
        }

        public class CountryDiscountFactory : DiscountFactory
        {
            private readonly string _countryIdentifier;
            public CountryDiscountFactory(string countryIdentifier)
            {
                _countryIdentifier = countryIdentifier;
            }

            public override DiscountService CreateDiscountService()
            {
                return new CountryDiscountService(_countryIdentifier);
            }
        }

        public class CodeDiscountFactory : DiscountFactory
        {
            private readonly Guid _code;

            public CodeDiscountFactory(Guid code)
            {
                _code = code;
            }
            public override DiscountService CreateDiscountService()
            {
                return new CodeDiscountService(_code);
            }
        }
    }
}
