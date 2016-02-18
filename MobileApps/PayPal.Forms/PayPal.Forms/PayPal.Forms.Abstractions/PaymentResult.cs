﻿using System;
using PayPal.Forms.Abstractions.Enum;
using Newtonsoft.Json;

namespace PayPal.Forms.Abstractions
{
	public class PaymentResult
	{
		public class Response
		{
			[JsonProperty(PropertyName = "create_time")]
			public string CreateTime { get; set; }

			[JsonProperty(PropertyName = "id")]
			public string Id { get; set; }

			[JsonProperty(PropertyName = "state")]
			public string State { get; set; }

			[JsonProperty(PropertyName = "intent")]
			public string Intent { get; set; }
		}

		public class Client
		{
			[JsonProperty(PropertyName = "paypal_sdk_version")]
			public string PaypalSdkVersion { get; set; }

			[JsonProperty(PropertyName = "environment")]
			public string Environment { get; set; }

			[JsonProperty(PropertyName = "platform")]
			public string Platform { get; set; }

			[JsonProperty(PropertyName = "product_name")]
			public string ProductName { get; set; }
		}

		public class PayPalPaymentResponse
		{
			[JsonProperty(PropertyName = "response")]
			public Response Response { get; set; }

			[JsonProperty(PropertyName = "client")]
			public Client Client { get; set; }

			[JsonProperty(PropertyName = "response_type")]
			public string ResponseType { get; set; }
		}

		public PaymentResultStatus Status { get; private set; }

		public string ErrorMessage { get; private set; }

		public PayPalPaymentResponse ServerResponse { get; private set; }

		public PaymentResult (PaymentResultStatus status, string errorMessage = null, PayPalPaymentResponse serverResponse = null)
		{
			Status = status;
			ErrorMessage = errorMessage;
			ServerResponse = serverResponse;
		}
	}
}

