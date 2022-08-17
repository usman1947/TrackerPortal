using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddingCountrySeedFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsoCode",
                table: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Country",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Country",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Label", "Value" },
                values: new object[,]
                {
                    { 1L, "China", "CN" },
                    { 2L, "China, Hong Kong", "HK" },
                    { 3L, "Singapore", "SG" },
                    { 4L, "United States", "US" },
                    { 5L, "Canada", "CA" },
                    { 6L, "Afghanistan", "AF" },
                    { 7L, "Åland Islands", "AX" },
                    { 8L, "Albania", "AL" },
                    { 9L, "Algeria", "DZ" },
                    { 10L, "American Samoa", "AS" },
                    { 11L, "Andorra", "AD" },
                    { 12L, "Angola", "AO" },
                    { 13L, "Anguilla", "AI" },
                    { 14L, "Antarctica", "AQ" },
                    { 15L, "Antigua and Barbuda", "AG" },
                    { 16L, "Argentina", "AR" },
                    { 17L, "Armenia", "AM" },
                    { 18L, "Aruba", "AW" },
                    { 19L, "Australia", "AU" },
                    { 20L, "Austria", "AT" },
                    { 21L, "Azerbaijan", "AZ" },
                    { 22L, "Bahamas", "BS" },
                    { 23L, "Bahrain", "BH" },
                    { 24L, "Bangladesh", "BD" },
                    { 25L, "Barbados", "BB" },
                    { 26L, "Belarus", "BY" },
                    { 27L, "Belgium", "BE" },
                    { 28L, "Belize", "BZ" },
                    { 29L, "Benin", "BJ" },
                    { 30L, "Bermuda", "BM" },
                    { 31L, "Bhutan", "BT" },
                    { 32L, "Bolivia, Plurinational State of", "BO" },
                    { 33L, "Bonaire, Sint Eustatius and Saba", "BQ" },
                    { 34L, "Bosnia and Herzegovina", "BA" },
                    { 35L, "Botswana", "BW" },
                    { 36L, "Bouvet Island", "BV" },
                    { 37L, "Brazil", "BR" },
                    { 38L, "British Indian Ocean Territory", "IO" },
                    { 39L, "Brunei Darussalam", "BN" },
                    { 40L, "Bulgaria", "BG" },
                    { 41L, "Burkina Faso", "BF" },
                    { 42L, "Burundi", "BI" },
                    { 43L, "Cambodia", "KH" },
                    { 44L, "Cameroon", "CM" },
                    { 45L, "Cape Verde", "CV" },
                    { 46L, "Cayman Islands", "KY" },
                    { 47L, "Central African Republic", "CF" },
                    { 48L, "Chad", "TD" },
                    { 49L, "Chile", "CL" },
                    { 50L, "Christmas Island", "CX" },
                    { 51L, "Cocos (Keeling) Islands", "CC" },
                    { 52L, "Colombia", "CO" },
                    { 53L, "Comoros", "KM" },
                    { 54L, "Congo", "CG" },
                    { 55L, "Congo, the Democratic Republic of the", "CD" },
                    { 56L, "Cook Islands", "CK" },
                    { 57L, "Costa Rica", "CR" },
                    { 58L, "Côte d'Ivoire", "CI" },
                    { 59L, "Croatia", "HR" },
                    { 60L, "Cuba", "CU" },
                    { 61L, "Curaçao", "CW" },
                    { 62L, "Cyprus", "CY" },
                    { 63L, "Czech Republic", "CZ" },
                    { 64L, "Denmark", "DK" },
                    { 65L, "Djibouti", "DJ" },
                    { 66L, "Dominica", "DM" },
                    { 67L, "Dominican Republic", "DO" },
                    { 68L, "Ecuador", "EC" },
                    { 69L, "Egypt", "EG" },
                    { 70L, "El Salvador", "SV" },
                    { 71L, "Equatorial Guinea", "GQ" },
                    { 72L, "Eritrea", "ER" },
                    { 73L, "Estonia", "EE" },
                    { 74L, "Ethiopia", "ET" },
                    { 75L, "Falkland Islands (Malvinas)", "FK" },
                    { 76L, "Faroe Islands", "FO" },
                    { 77L, "Fiji", "FJ" },
                    { 78L, "Finland", "FI" },
                    { 79L, "France", "FR" },
                    { 80L, "French Guiana", "GF" },
                    { 81L, "French Polynesia", "PF" },
                    { 82L, "French Southern Territories", "TF" },
                    { 83L, "Gabon", "GA" },
                    { 84L, "Gambia", "GM" },
                    { 85L, "Georgia", "GE" },
                    { 86L, "Germany", "DE" },
                    { 87L, "Ghana", "GH" },
                    { 88L, "Gibraltar", "GI" },
                    { 89L, "Greece", "GR" },
                    { 90L, "Greenland", "GL" },
                    { 91L, "Grenada", "GD" },
                    { 92L, "Guadeloupe", "GP" },
                    { 93L, "Guam", "GU" },
                    { 94L, "Guatemala", "GT" },
                    { 95L, "Guernsey", "GG" },
                    { 96L, "Guinea", "GN" },
                    { 97L, "Guinea-Bissau", "GW" },
                    { 98L, "Guyana", "GY" },
                    { 99L, "Haiti", "HT" },
                    { 100L, "Heard Island and McDonald Islands", "HM" },
                    { 101L, "Holy See (Vatican City State)", "VA" },
                    { 102L, "Honduras", "HN" },
                    { 103L, "Hungary", "HU" },
                    { 104L, "Iceland", "IS" },
                    { 105L, "India", "IN" },
                    { 106L, "Indonesia", "ID" },
                    { 107L, "Iran, Islamic Republic of", "IR" },
                    { 108L, "Iraq", "IQ" },
                    { 109L, "Ireland", "IE" },
                    { 110L, "Isle of Man", "IM" },
                    { 111L, "Israel", "IL" },
                    { 112L, "Italy", "IT" },
                    { 113L, "Jamaica", "JM" },
                    { 114L, "Japan", "JP" },
                    { 115L, "Jersey", "JE" },
                    { 116L, "Jordan", "JO" },
                    { 117L, "Kazakhstan", "KZ" },
                    { 118L, "Kenya", "KE" },
                    { 119L, "Kiribati", "KI" },
                    { 120L, "Korea, Democratic People's Republic of", "KP" },
                    { 121L, "Korea, Republic of", "KR" },
                    { 122L, "Kuwait", "KW" },
                    { 123L, "Kyrgyzstan", "KG" },
                    { 124L, "Lao People's Democratic Republic", "LA" },
                    { 125L, "Latvia", "LV" },
                    { 126L, "Lebanon", "LB" },
                    { 127L, "Lesotho", "LS" },
                    { 128L, "Liberia", "LR" },
                    { 129L, "Libya", "LY" },
                    { 130L, "Liechtenstein", "LI" },
                    { 131L, "Lithuania", "LT" },
                    { 132L, "Luxembourg", "LU" },
                    { 133L, "Macao", "MO" },
                    { 134L, "Macedonia, the Former Yugoslav Republic of", "MK" },
                    { 135L, "Madagascar", "MG" },
                    { 136L, "Malawi", "MW" },
                    { 137L, "Malaysia", "MY" },
                    { 138L, "Maldives", "MV" },
                    { 139L, "Mali", "ML" },
                    { 140L, "Malta", "MT" },
                    { 141L, "Marshall Islands", "MH" },
                    { 142L, "Martinique", "MQ" },
                    { 143L, "Mauritania", "MR" },
                    { 144L, "Mauritius", "MU" },
                    { 145L, "Mayotte", "YT" },
                    { 146L, "Mexico", "MX" },
                    { 147L, "Micronesia, Federated States of", "FM" },
                    { 148L, "Moldova, Republic of", "MD" },
                    { 149L, "Monaco", "MC" },
                    { 150L, "Mongolia", "MN" },
                    { 151L, "Montenegro", "ME" },
                    { 152L, "Montserrat", "MS" },
                    { 153L, "Morocco", "MA" },
                    { 154L, "Mozambique", "MZ" },
                    { 155L, "Myanmar", "MM" },
                    { 156L, "Namibia", "NA" },
                    { 157L, "Nauru", "NR" },
                    { 158L, "Nepal", "NP" },
                    { 159L, "Netherlands", "NL" },
                    { 160L, "New Caledonia", "NC" },
                    { 161L, "New Zealand", "NZ" },
                    { 162L, "Nicaragua", "NI" },
                    { 163L, "Niger", "NE" },
                    { 164L, "Nigeria", "NG" },
                    { 165L, "Niue", "NU" },
                    { 166L, "Norfolk Island", "NF" },
                    { 167L, "Northern Mariana Islands", "MP" },
                    { 168L, "Norway", "NO" },
                    { 169L, "Oman", "OM" },
                    { 170L, "Pakistan", "PK" },
                    { 171L, "Palau", "PW" },
                    { 172L, "Palestine, State of", "PS" },
                    { 173L, "Panama", "PA" },
                    { 174L, "Papua New Guinea", "PG" },
                    { 175L, "Paraguay", "PY" },
                    { 176L, "Peru", "PE" },
                    { 177L, "Philippines", "PH" },
                    { 178L, "Pitcairn", "PN" },
                    { 179L, "Poland", "PL" },
                    { 180L, "Portugal", "PT" },
                    { 181L, "Puerto Rico", "PR" },
                    { 182L, "Qatar", "QA" },
                    { 183L, "Réunion", "RE" },
                    { 184L, "Romania", "RO" },
                    { 185L, "Russian Federation", "RU" },
                    { 186L, "Rwanda", "RW" },
                    { 187L, "Saint Barthélemy", "BL" },
                    { 188L, "Saint Helena, Ascension and Tristan da Cunha", "SH" },
                    { 189L, "Saint Kitts and Nevis", "KN" },
                    { 190L, "Saint Lucia", "LC" },
                    { 191L, "Saint Martin (French part)", "MF" },
                    { 192L, "Saint Pierre and Miquelon", "PM" },
                    { 193L, "Saint Vincent and the Grenadines", "VC" },
                    { 194L, "Samoa", "WS" },
                    { 195L, "San Marino", "SM" },
                    { 196L, "Sao Tome and Principe", "ST" },
                    { 197L, "Saudi Arabia", "SA" },
                    { 198L, "Senegal", "SN" },
                    { 199L, "Serbia", "RS" },
                    { 200L, "Seychelles", "SC" },
                    { 201L, "Sierra Leone", "SL" },
                    { 202L, "Sint Maarten (Dutch part)", "SX" },
                    { 203L, "Slovakia", "SK" },
                    { 204L, "Slovenia", "SI" },
                    { 205L, "Solomon Islands", "SB" },
                    { 206L, "Somalia", "SO" },
                    { 207L, "South Africa", "ZA" },
                    { 208L, "South Georgia and the South Sandwich Islands", "GS" },
                    { 209L, "South Sudan", "SS" },
                    { 210L, "Spain", "ES" },
                    { 211L, "Sri Lanka", "LK" },
                    { 212L, "Sudan", "SD" },
                    { 213L, "Suriname", "SR" },
                    { 214L, "Svalbard and Jan Mayen", "SJ" },
                    { 215L, "Swaziland", "SZ" },
                    { 216L, "Sweden", "SE" },
                    { 217L, "Switzerland", "CH" },
                    { 218L, "Syrian Arab Republic", "SY" },
                    { 219L, "Taiwan, Province of China", "TW" },
                    { 220L, "Tajikistan", "TJ" },
                    { 221L, "Tanzania, United Republic of", "TZ" },
                    { 222L, "Thailand", "TH" },
                    { 223L, "Timor-Leste", "TL" },
                    { 224L, "Togo", "TG" },
                    { 225L, "Tokelau", "TK" },
                    { 226L, "Tonga", "TO" },
                    { 227L, "Trinidad and Tobago", "TT" },
                    { 228L, "Tunisia", "TN" },
                    { 229L, "Turkey", "TR" },
                    { 230L, "Turkmenistan", "TM" },
                    { 231L, "Turks and Caicos Islands", "TC" },
                    { 232L, "Tuvalu", "TV" },
                    { 233L, "Uganda", "UG" },
                    { 234L, "Ukraine", "UA" },
                    { 235L, "United Arab Emirates", "AE" },
                    { 236L, "United Kingdom", "GB" },
                    { 237L, "United States Minor Outlying Islands", "UM" },
                    { 238L, "Uruguay", "UY" },
                    { 239L, "Uzbekistan", "UZ" },
                    { 240L, "Vanuatu", "VU" },
                    { 241L, "Venezuela, Bolivarian Republic of", "VE" },
                    { 242L, "Viet Nam", "VN" },
                    { 243L, "Virgin Islands, British", "VG" },
                    { 244L, "Virgin Islands, U.S.", "VI" },
                    { 245L, "Wallis and Futuna", "WF" },
                    { 246L, "Western Sahara", "EH" },
                    { 247L, "Yemen", "YE" },
                    { 248L, "Zambia", "ZM" },
                    { 249L, "Zimbabwe", "ZW" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DropColumn(
                name: "Label",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Country");

            migrationBuilder.AddColumn<string>(
                name: "IsoCode",
                table: "Country",
                type: "text",
                nullable: true);
        }
    }
}
