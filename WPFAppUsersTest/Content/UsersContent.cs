using SimplePosts.Server.Repository.Base;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using WPFAppUsersTestCore.Models.Entities;

namespace WPFAppUsersTest.Content
{
    public class UsersContent
    {
        RepositoryBase<User> _usersRepository;
        RepositoryBase<Subdivision> _subdivisionsRepository;

        public UsersContent()
        {
            _usersRepository = new RepositoryBase<User>();
            _subdivisionsRepository = new RepositoryBase<Subdivision>();
        }

        public TableRowGroup GetAllUsers()
        {
            // ДАННЫЕ
            User[] users = _usersRepository.GetAll().ToArray();
            IEnumerable<Subdivision> subdivisions = _subdivisionsRepository.GetAll();

            TableRowGroup tableRowGroup = new TableRowGroup();

            TableRow currentRow;

            for (int i = 0; i < users.Length; i++)
            {
                User user = users[i];

                Subdivision subdivision = subdivisions.FirstOrDefault(s => s.Id == user.SubdivisionId);

                currentRow = new TableRow
                {
                    DataContext = user.Id,
                    Background = i % 2 == 0 ? Brushes.LightGreen : Brushes.White
                };

                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(user.Surname))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(user.Name))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(user.Patronymic))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(user.DateBirth.ToShortDateString()))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(user.Gender.ToString()))));
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(subdivision?.Name))) { ColumnSpan = 2 });

                tableRowGroup.Rows.Add(currentRow);
            }

            return tableRowGroup;
        }

        public IEnumerable<ComboBoxItem> GetComboBoxItemsSubdivisions()
        {
            var subdivisions = _subdivisionsRepository.GetAll();

            return subdivisions.Select(s => new ComboBoxItem
            {
                DataContext = s.Id,
                Content = s.Name
            });
        }
    }
}
