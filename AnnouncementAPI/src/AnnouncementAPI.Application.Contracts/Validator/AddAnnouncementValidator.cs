using AnnouncementAPI.Announcement.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace AnnouncementAPI.Validator
{
    public class AddAnnouncementValidator : AbstractValidator<AddAnnouncement>
    {
        public AddAnnouncementValidator()
        {
            RuleFor(input => input.Title)
                  .MaximumLength(100).WithMessage("Title kısmı maksimum 100 karakter olabilir.");

            RuleFor(input => input.Title)
                  .NotEmpty().WithMessage("Title kısmı boş bırakılamaz");

            RuleFor(input => input.Content)
                  .NotEmpty().WithMessage("Content kısmı boş bırakılamaz");

            RuleFor(input => input.Content)
                 .MaximumLength(300).WithMessage("Content kısmı maksimum 300 karakter olabilir.");
        }
    }
}
