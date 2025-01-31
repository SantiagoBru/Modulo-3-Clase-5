﻿#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ejercicio5Modulo3.Models;

public partial class User
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Genero { get; set; }
    public string Email { get; set; }
    public string NombreUsuario { get; set; }
    public string Password { get; set; }
    public string Ciudad { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    public User(
            string nombre, string apellido, int edad,
            string genero, string email, string nombreUsuario, string password,
            string ciudad, string estado, string pais)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Genero = genero;
        Email = email;
        NombreUsuario = nombreUsuario;
        Password = password;
        Ciudad = ciudad;
        Estado = estado;
        Pais = pais;
    }
}