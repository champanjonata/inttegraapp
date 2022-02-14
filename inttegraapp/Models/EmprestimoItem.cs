using System;

namespace inttegraapp.Models
{
    public class EmprestimoItem
    {
        public int Id { get; set; }

        public Emprestimo EmprestimoId { get; set; }

        public DateTime DataDevolucao { get; set; }

        public String Item { get; set; }

        public bool DevolvidoSN { get; set; }

        public EmprestimoItem()
        {

        }

        public EmprestimoItem(int id, Emprestimo emprestimoId, DateTime dataDevolucao, string item, bool devolvidoSN)
        {
            Id = id;
            EmprestimoId = emprestimoId;
            DataDevolucao = dataDevolucao;
            Item = item;
            DevolvidoSN = devolvidoSN;
        }
    }
}
