﻿using System.Globalization;

namespace secao3exerpedido
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double subTotal()
        {
            double desconto = produto.preco * porcentagemDesconto / 100.00;
            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString()
        {
            return produto.descricao
                + ", Preço: "
                + produto.preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Qte: "
                + quantidade
                + ", Desconto: "
                + porcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
