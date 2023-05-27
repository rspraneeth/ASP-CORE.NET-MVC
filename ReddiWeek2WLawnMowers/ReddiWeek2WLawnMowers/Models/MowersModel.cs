using System.ComponentModel.DataAnnotations;
// Created by Satya Praneeth Reddi
namespace ReddiWeek2WLawnMowers.Models
{
    public class MowersModel
    {
        /*
         * 11111111111111111111
         * Properties
         * These properties map to the form controls  --  their name properties.
         * The annotations in square brackets on top of the property declarations is to make sure
         * the data is validated according to these annotations when the binding model validates.
         * The Quote property is the result that will be displayed for the customer.
         * The CalculateQuote method calculates and sets the quote property.
         */
        [Required]
        public string? Name { get; set; }

        [Range(1000, 500000)]
        public double? Area { get; set; }

        [Range(1, 20)]
        public int? NumberOfWeeks { get; set; }

        public double Quote { get; set; }

        public void CalculateQuote()
        {
            if (Area != null && NumberOfWeeks != null)
            {
                if (Area > 35000) { Quote = (double)(NumberOfWeeks * 40); }
                else if (Area > 25000) { Quote = (double)(NumberOfWeeks * 35); }
                else if (Area > 10000) { Quote = (double)(NumberOfWeeks * 30); }
                else { Quote = (double)(NumberOfWeeks * 25); }
            } // if condition null check
        } // CalculateQuote method close
    } // class
} // namespace
