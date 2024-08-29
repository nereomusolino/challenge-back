using challenge_backend.Controllers;
using challenge_backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace challenge_backend.Services
{
    public class PedidoService : IPedidoService
    {
        public PedidoService() { }

        public List<Producto> GetProductos()
        {

            var productos = new List<Producto>
            {
                new Producto
                {
                    Codigo = "K1020",
                    Descripcion = "Colchon Telgo",
                    Precio = 10256.12m,
                    Deposito = 1
                },
                new Producto
                {
                    Codigo = "K1022%%",
                    Descripcion = "Colchon Seally",
                    Precio = 18256.12m,
                    Deposito = 4
                },
                new Producto
                {
                    Codigo = "K1024",
                    Descripcion = "Sommier Telgo",
                    Precio = 14256.12m,
                    Deposito = 1
                },
                new Producto
                {
                    Codigo = "K1026",
                    Descripcion = "Sommier Seally",
                    Precio = 13256.12m,
                    Deposito = 1
                },
                new Producto
                {
                    Codigo = "F1026",
                    Descripcion = "Almohada Seally",
                    Precio = 0m,
                    Deposito = 1
                },
                new Producto
                {
                    Codigo = "F1026",
                    Descripcion = "Almohada Seally",
                    Precio = 3250.12m,
                    Deposito = 4
                },
                new Producto
                {
                    Codigo = "K1024",
                    Descripcion = "Sommier Telgo",
                    Precio = 14256.12m,
                    Deposito = 4
                },
                new Producto
                {
                    Codigo = "K1026",
                    Descripcion = "Sommier Seally",
                    Precio = -13256.12m,
                    Deposito = 8
                },
                new Producto
                {
                    Codigo = "K!°1026",
                    Descripcion = "Sommier Seally",
                    Precio = -13256.12m,
                    Deposito = 8
                }
            };

            return productos;

        }

        public bool PostPedidos(Pedido pedido)
        {
            decimal total = 0;
            bool flagCaracteres = false;
            
            foreach (var item in pedido.Productos)
            {
                total = +item.Precio;
                if (ContieneCaracteresEspeciales(item.Descripcion)) flagCaracteres = true;
            }

            if (total == 0) return false;

            if (flagCaracteres) return false;

            if (pedido == null) return false;

            return true;

        }

        public bool ContieneCaracteresEspeciales(string desc)
        {
            string caracteresEspeciales = @"[!@#$%^&*(),.?""':;{}|<>]";

            return Regex.IsMatch(desc, caracteresEspeciales);
        }
    }
}
