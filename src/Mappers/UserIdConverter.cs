﻿using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

namespace LiteBorder.AspNetCore.Identity.DynamoDb
{
    public class UserIdConverter : IPropertyConverter
    {
        public DynamoDBEntry ToEntry(object value)
        {
            return $"User#{value}";
        }

        public object FromEntry(DynamoDBEntry entry)
        {
            return entry.AsString().Replace("User#", "");
        }
    }
}
