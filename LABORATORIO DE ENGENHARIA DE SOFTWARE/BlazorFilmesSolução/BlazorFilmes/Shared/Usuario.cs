using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorFilmes.Shared
{
    public class Usuario
    {
		[Required]
		public string Titulo { get; set; }
		[Required]
		public string Nome { get; set; }
		[Required]
		public string Sobrenome { get; set; }
		[Required]
		public DateTime? DatadeNascimento { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		[StringLength(16)]
		[MinLength(6)]
		[PasswordPropertyText]
		public string Senha { get; set; }
		[Required]
		[StringLength(16)]
		[MinLength(6)]
		[PasswordPropertyText]
		[Compare("Senha")]
		public string ConfirmarSenha { get; set; }
		[Required]
		[Range(typeof(bool),"true","true", ErrorMessage = "Campo obrigatório")]
		public bool Termos { get; set; }
	}
}
