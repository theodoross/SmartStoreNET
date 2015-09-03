﻿using System;
using SmartStore.Core.Domain.Catalog;

namespace SmartStore.Core.Domain.DataExchange
{
	[Serializable]
	public class ExportProjection
	{
		public ExportProjection()
		{
			RemoveCriticalCharacters = true;
			CriticalCharacters = "¼,½,¾";
			PriceType = PriceDisplayType.PreSelectedPrice;
		}

		public int? StoreId { get; set; }

		/// <summary>
		/// The language to be applied to the export
		/// </summary>
		public int? LanguageId { get; set; }

		/// <summary>
		/// The currency to be applied to the export
		/// </summary>
		public int? CurrencyId { get; set; }

		public int? CustomerId { get; set; }

		public ExportDescriptionMerging? DescriptionMerging { get; set; }

		public bool DescriptionToPlainText { get; set; }

		public string AppendDescriptionText { get; set; }

		public bool RemoveCriticalCharacters { get; set; }

		public string CriticalCharacters { get; set; }

		public PriceDisplayType? PriceType { get; set; }

		public bool ConvertNetToGrossPrices { get; set; }

		public string Brand { get; set; }

		public int PictureSize { get; set; }

		public string ShippingTime { get; set; }

		public decimal? ShippingCosts { get; set; }

		public decimal? FreeShippingThreshold { get; set; }

		public bool AttributeCombinationAsProduct { get; set; }

		public ExportAttributeValueMerging? AttributeCombinationValueMerging { get; set; }
	}
}