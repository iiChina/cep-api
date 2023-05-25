﻿using BuscaCEP.Models;
using Newtonsoft.Json;

namespace BuscaCEP.Service;

public class CorreioService
{
    private readonly HttpClient _httpClient;

	public CorreioService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<Endereco> BuscarEnderecoPorCep(string cep)
	{
		try
		{
			var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
			var json = await response.Content.ReadAsStringAsync();
			if (json.Length > 20)
				return JsonConvert.DeserializeObject<Endereco>(json);
			else
				return null;
		}
		catch 
		{
			return null;
		}
	}
}
