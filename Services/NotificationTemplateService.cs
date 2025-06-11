using Lms.Data;
using Lms.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lms.Services
{
    public class NotificationTemplateService
    {
        private readonly LmsDbContext _context;

        public NotificationTemplateService(LmsDbContext context)
        {
            _context = context;
        }

        public NotificationTemplate GetTemplate(string eventType, string deliveryChannel)
        {
            return _context.NotificationTemplates
                .FirstOrDefault(t => t.EventType == eventType && t.DeliveryChannel == deliveryChannel);
        }

        public string FillTemplate(string template, Dictionary<string, string> values)
        {
            foreach (var pair in values)
            {
                template = template.Replace($"{{{{{pair.Key}}}}}", pair.Value);
            }
            return template;
        }
    }
}
