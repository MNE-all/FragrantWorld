using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Context.Models
{
    /// <summary>
    /// Сущность заказа
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Клиент. Поле может быть пустым
        /// </summary>
        public User? Client { get; set; }
        /// <summary>
        /// Cвязь один ко многим
        /// </summary>
        public int? ClientId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Cвязь один ко многим
        /// </summary>
        public string ProductArticleNumber { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// Пункт выдачи
        /// </summary>
        public PickUpPoint PickUpPoint { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTimeOffset OrderDate { get; set; }
        /// <summary>
        /// Дата доставки
        /// </summary>
        public DateTimeOffset DeliveryDate { get; set; }
        /// <summary>
        /// Код для получения
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Актуальность заказа. Если True, то заказ новый. Если False, то заказ завершённый
        /// </summary>
        public bool IsActive { get; set; }
    }
}
