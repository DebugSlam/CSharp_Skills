using System;
using System.Text.Json.Serialization;

namespace IdeaAPITesting.Models
{
	public class ApiResponseDTO
	{

		[JsonPropertyName("msg")]
		public string Msg { get; set; }

        [JsonPropertyName("id")]
        public string IdeaId { get; set; }
		
	}
}

