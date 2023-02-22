Public Class Form1
    Public Country() As String = {"Afghanistan", "Algeria", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Austria", "Azerbaijan",
            "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia/Herzegovina",
            "Botswana", "Brazil", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep.",
            "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Rep.", "Republic of the Congo", "Costa Rica", "Cote d'Ivoire",
            "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador",
            "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana",
            "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia",
            "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "North Korea", "South Korea",
            "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Madagascar",
            "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Fed. States of Micronesia",
            "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands",
            "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papa New Guinea", "Paraguay", "Peru",
            "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia",
            "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovak Republic", "Slovenia", "Solomon Islands", "Somalia",
            "South Africa", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Tajikistan", "Tanzania", "Thailand", "Togo",
            "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom",
            "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"}
    Public Capital() As String = {"Kabul", "Algiers", "Luanda", "Saint John's", "Buenos Aires", "Yerevan", "Vienna", "Baku", "Nassau", "Manama", "Dhaka",
            "Bridgetown", "Minsk", "Brussels", "Belmopan", "Porto-Novo", "Thimphu", "La Paz; Sucre", "Sarajevo", "Gaborone", "Brasilia", "Sofia", "Ouagadougou",
            "Bujumbura", "Phnom Penh", "Yaounde", "Ottawa", "Praia", "Bangui", "N'Djamena", "Santiago", "Beijing", "Bogota", "Moroni", "Kinshasa", "Brazzaville",
            "San Jose", "Yamoussoukro; Abidjan", "Zagreb", "Havana", "Nicosia", "Prague", "Copenhagen", "Djibouti", "Rosesau", "Santo Domingo", "Quito",
            "Cairo", "San Salvador", "Malabo", "Asmara", "Tallinn", "Addis Ababa", "Suva", "Helsinki", "Paris", "Libreville", "Banjul", "Tbilisi", "Berlin",
            "Accra", "Athens", "St. George's", "Guatemala City", "Conakry", "Bissau", "Georgetown", "Port-au-Prince", "Tegucigalpa", "Budapest", "Reykjavik",
            "New Delhi", "Jakarta", "Tehran", "Baghdad", "Dublin", "Jerusalem", "Rome", "Kingston", "Tokyo", "Amman", "Astana", "Nairobi", "Tarawa Atoll",
            "Pyongyang", "Seoul", "Pristina", "Kuwait City", "Bishkek", "Vientiane", "Riga", "Beirut", "Maseru", "Monrovia", "Tripoli", "Vaduz", "Vilnius",
            "Antananarivo", "Lilongwe", "Kuala Lumpur", "Male", "Bamako", "Valletta", "Majuro", "Nouakchott", "Port Louis", "Mexico City", "Palikir", "Chisinau",
            "Monaco", "Ulaanbaatar", "Podgorica", "Rabat", "Maputo", "Nypyidaw", "Windhoek", "Yaren", "Kathmandu", "Amsterdam; The Hague", "Wellington",
            "Managua", "Niamey", "Abuja", "Oslo", "Muscat", "Islamabad", "Melekeok", "Panama City", "Port Moresby", "Asuncion", "Lima", "Manila", "Warsaw",
            "Lisbon", "Doha", "Bucharest", "Moscow", "Kigali", "Apia", "San Marino", "Sao Tome", "Riyadh", "Dakar", "Belgrade", "Victoria", "Freetown",
            "Singapore", "Bratislava", "Ljubljana", "Honiara", "Mogadishu", "Pretoria; Cape Town", "Madrid", "Colombo", "Khartoum", "Paramaribo", "Stockholm",
            "Berne", "Damascus", "Dushanbe", "Dar es Salaam; Dodoma", "Bangkok", "Lome", "Nuku'alofa", "Port-of-Spain", "Tunis", "Ankara", "Ashgabat",
            "Vaiaku", "Kampala", "Kiev", "Abu Dhabi", "London", "Washington D.C.", "Montevideo", "Tashkent", "Port-Vila", "Caracas", "Hanoi", "Sanaa",
            "Lusaka", "Harare"}
    Public Currency() As String = {"Afghani", "Algerian Dinar", "Kwanza", "East Caribbean Dollar", "Argentine Peso", "Dram", "Euro",
            "Manat", "Bahamian Dollar", "Bahraini Dinar", "Taka", "Barbadian Dollar", "Belarusian Ruble", "Euro", "Belize Dollar",
            "CFA Franc", "Ngultrum", "Boliviano", "Convertible Mark", "Pula", "Real", "Lev", "CFA Franc", "Burundi Franc", "Riel", "CFA Franc",
            "Canadian Dollar", "Cape Verdean Escudo", "CFA Franc", "CFA Franc", "Chilean Peso", "Chinese Yuan", "Colombian Peso",
            "Comorian Franc", "Congolese Franc", "CFA Franc", "Colon", "CFA Franc", "Croatian", "Cuban Peso", "Euro", "Czech Koruna",
            "Danish Krone", "Djiboutian Franc", "East Caribbean Dollar", "Dominican Peso", "U.S. Dollar", "Egyptian Pound",
            "U.S. Dollar", "CFA Franc", "Nakfa", "Estonian Kroon; Euro", "Birr", "Fijian Dollar", "Euro", "Euro; CFP Franc", "CFA Franc",
            "Dalasi", "Lari", "Euro", "Ghanaian Cedi", "Euro", "East Caribbean Dollar", "Quetzal", "Guinean Franc", "CFA Franc", "Guyanese Dollar",
            "Gourde", "Lempira", "Forint", "Icelandic Krona", "Indian Rupee", "Rupiah", "Rial", "Iraqi Dinar", "Euro", "Shekel", "Euro",
            "Jamaican Dollar", "Yen", "Jordanian Dinar", "Tenge", "Kenyan Shilling", "Kiribati Dollar", "North Korean Won", "South Korean Won",
            "Euro", "Kuwaiti Dollar", "Som", "Kip", "Lats", "Lebanese Pound", "Loti", "Liberian Dollar", "Libyan Dinar", "Swiss Franc",
            "Lithuanian Litas", "Malagasy Ariary", "Malawi Kwacha", "Ringgit", "Maldivian Rufiyaa", "West Af. CFA Franc", "Euro",
            "U.S. Dollar", "Ouguiya", "Mauritian Rupee", "Mexican Peso", "U.S. Dollar", "Moldovan Leu", "Euro", "Togrog",
            "Euro", "Moroccan Dirham", "Mozambican Metical", "Kyat", "Namibian Dollar", "Australian Dollar", "Nepalese Rupee", "Euro",
            "New Zealand Dollar", "Cordoba", "CFA Franc", "Naira", "Norwegian Krone", "Omani Rial", "Pakistani Rupee", "U.S. Dollar",
            "Balboa", "Papa New Guinean Kina", "Guarani", "Nuevo Sol", "Phillipine Peso", "Złoty", "Euro", "Qatari Riyal", "Romanian Rupee",
            "Ruble", "Rwandan Franc", "Tala", "Euro", "Dobra", "Saudi Riyal", "CFA Franc", "Serbian Dinar", "Seychoellois Rupee", "Leone",
            "Singapore Dollar", "Euro", "Euro", "Solomon Islands Dollar", "Somali Shilling", "Rand", "Euro", "Sri Lankan Rupee", "Sudanese Pound",
            "Surinamese Dollar", "Swedish Krona", "Swiss Franc", "Syrian Pound", "Somoni", "Tanzanian Schilling", "Thai Baht", "CFA Franc",
            "Pa'anga", "Trinidad/Tobago Dollar", "Tunisian Dinar", "Turkish Lira", "Turkmen New Manat", "Tuvaluan Dollar", "Ugandan Shilling",
            "Hryvnia", "Dirham", "Pound Sterling", "U.S. Dollar", "Uruguayan Peso", "Uzbekistan Som", "Vanuatu Vatu", "Bolivar Fuerte",
            "Dong", "Yemeni Rial", "Zambian Kwacha", "U.S. Dollar"}
    Public Language() As String = {"Dari Persian", "Arabic", "Portuguese", "English", "Spanish", "Armenian", "German", "Azerbaijani", "English",
            "Arabic", "Bangla", "English", "Belarusian", "Dutch", "English", "French", "Dzongkha", "Spanish", "Bosnian", "English; Tswana", "Portuguese",
            "Bulgarian", "French", "Kirundi", "Khmer", "French", "English", "Portuguese", "Sango", "French", "Spanish", "Mandarin", "Spanish", "Comorian", "French",
            "French", "Spanish", "French", "Kuna", "Spanish", "Greek", "Czech", "Danish", "Arabic", "English", "Spanish", "Spanish", "Arabic", "Spanish", "Spanish",
            "Arabic", "Estonian", "Amharic", "English", "Finnish", "French", "French", "English", "Georgian", "German", "English", "Greek", "English", "Spanish",
            "French", "Portuguese", "English", "Haitian Creole", "Spanish", "Hungarian", "Icelandic", "Hindi", "Indonesian", "Persian", "Arabic", "English",
            "Hebrew", "Italian", "English", "Japanese", "Arabic", "Kazakh", "Swahili", "English", "Korean", "Korean", "Albanian", "Arabic", "Kyrgyz", "Lao (Laotian)",
            "Latvian", "Arabic", "Sesotho", "English", "Arabic", "German", "Lithuanian", "Malagasy", "English", "Malay", "Dhivehi", "French", "Maltese", "Marshallese",
            "Arabic", "English", "Spanish", "English", "Moldovan", "French", "Mongolian", "Montenegrin", "Arabic", "Portuguese", "Burmese", "English", "English",
            "Nepali", "Dutch", "English", "Spanish", "French", "English", "Norwegian", "Arabic", "Urdu", "English", "Spanish", "English", "Spanish", "Spanish",
            "Filipino", "Polish", "Portuguese", "Arabic", "Romanian", "Russian", "Kinyarwanda", "Samoan", "Italian", "Portuguese", "Arabic", "French", "Serbian",
            "Seychellois Creole", "Krio", "English", "Slovak", "Slovene", "Solomons Pijin", "Somali; Arabic", "Zulu", "Spanish", "Sinhala", "Arabic",
            "Dutch", "Swedish", "German", "Arabic", "Tajik", "Swahili", "Thai", "French", "Tongan", "English", "Tunisian", "Turkish", "Turkmen", "Tuvaluan",
            "Swahili", "Ukranian", "Arabic", "English", "English", "Spanish", "Uzbek", "Bislama", "Spanish", "Vietnamese", "Arabic", "English", "English"}
    Public Population() As Decimal = {37.2, 42.2, 30.8, 0.1, 44.5, 3, 8.8, 9.9, 0.4, 1.6, 161.4, 0.3, 9.5, 11.4, 0.4, 11.5, 0.8, 11.4, 3.3, 2.3, 209.5, 7,
            19.8, 11.2, 16.2, 25.2, 37.1, 0.5, 4.7, 15.5, 18.7, 1392.7, 49.6, 0.8, 84.1, 5.2, 5, 25.1, 4.1, 11.3, 1.2, 10.6, 5.8, 1, 0.1, 10.6, 17.1, 98.4,
            6.4, 1.3, 0, 1.3, 109.2, 0.9, 5.5, 67, 2.1, 2.3, 3.7, 82.9, 29.8, 10.7, 0.1, 17.2, 12.4, 1.9, 0.8, 11.1, 9.6, 9.8, 0.4, 1352.6, 267.7, 81.8, 38.4,
            4.9, 8.9, 60.4, 2.9, 126.5, 10, 18.3, 51.4, 0.1, 25.5, 51.6, 1.8, 4.1, 6.3, 7.1, 1.9, 6.8, 2.1, 4.8, 6.7, 0, 2.8, 26.3, 18.1, 31.5, 0.5, 19.1,
            0.5, 0.1, 4.4, 1.3, 126.2, 0.1, 3.5, 0, 3.2, 0.6, 36, 29.5, 53.7, 2.4, 0, 28.1, 17.2, 4.9, 6.5, 22.4, 195.9, 5.3, 4.8, 212.2, 0, 4.2, 8.6, 7,
            32, 106.7, 38, 10.3, 2.8, 19.5, 144.5, 12.3, 0.2, 0, 0.2, 33.7, 15.9, 7, 0.1, 7.7, 5.6, 5.4, 2.1, 0.7, 15, 57.8, 46.7, 21.7, 41.8, 0.6, 10.2,
            8.5, 16.9, 9.1, 56.3, 69.4, 7.9, 0.1, 1.4, 11.6, 82.3, 5.9, 0, 42.7, 44.6, 9.6, 66.5, 327.2, 3.4, 33, 0.3, 28.9, 95.5, 28.5, 17.4, 14.4}
    Public SurfaceArea() As Decimal = {652900, 2381700, 1246700, 0, 2780400, 29700, 83900, 86600, 13900, 0, 147600, 0, 207600, 30500, 23000, 114800,
            38400, 1098600, 51200, 581700, 8515800, 111000, 274200, 27800, 181000, 475400, 9984700, 4000, 623000, 1284000, 756700, 9562900, 1141700,
            1900, 2344900, 342000, 51100, 322500, 56600, 109900, 9300, 78900, 42900, 23200, 0, 48700, 256400, 1001500, 21000, 28100, 117600, 45300,
            1104300, 18300, 338500, 549100, 267700, 11300, 69700, 357600, 238500, 132000, 0, 108900, 245900, 36100, 215000, 27800, 112500, 93000, 103000,
            3287300, 1913600, 1745200, 435100, 703000, 22100, 301300, 11000, 378000, 89300, 2724900, 580400, 0, 120500, 100300, 10900, 17800, 200000,
            236800, 64500, 10500, 30400, 111400, 1759500, 0, 65300, 587300, 118500, 330300, 0, 1240200, 0, 0, 1030700, 2000, 1964400, 0, 33900, 0, 1564100,
            13800, 446600, 786400, 676600, 824300, 0, 147200, 41500, 267700, 130400, 1267000, 923800, 625200, 309500, 796100, 0, 75400, 462800,
            406800, 1285200, 300000, 312700, 92200, 11600, 238400, 17098300, 26300, 2800, 0, 1000, 2149700, 196700, 88400, 0, 72300, 0, 49000, 20700,
            28900, 637700, 1219100, 505900, 65600, 0, 163800, 447400, 41300, 185200, 141400, 947300, 513100, 56800, 0, 5100, 163600, 785400, 488100, 0,
            241600, 603600, 83600, 243600, 9831500, 176200, 447400, 12200, 912100, 331200, 528000, 752600, 390800}
    Public GNP() As Decimal = {20.3, 171.6, 103.8, 1.5, 550.3, 12.5, 435.7, 40.3, 11.5, 34.4, 282.0, 4.4, 53.8, 519.0, 1.8, 10.0, 2.3, 38.2,
            18.9, 17.5, 1915.3, 62.3, 13.0, 3.1, 22.5, 36.4, 1662.4, 1.9, 2.2, 10.4, 274.8, 13184.1, 307.4, 1.1, 41.5, 8.6, 57.6, 40.4, 56.6,
            0, 22.9, 215.2, 348.7, 2.1, 0.5, 78.3, 104.5, 275.4, 24.5, 9.2, 0, 27.7, 86.7, 5.2, 263.9, 2751.4, 14.4, 1.6, 15.4, 3934.7, 63.4, 209.6,
            1.1, 76.0, 10.3, 1.4, 3.7, 8.9, 22.4, 142.5, 20.9, 2733.5, 1026.8, 441.0, 193.5, 288.1, 362.9, 2028.1, 14.7, 5231.3, 41.9, 143.1, 83.1,
            0.4, 0, 1580.1, 7.8, 139.4, 7.7, 17.4, 32.5, 52.7, 2.9, 2.9, 42.3, 0, 48.4, 11.4, 6.5, 329.9, 4.8, 15.9, 12.7, 0.3, 5.2, 15.2, 1158.0,
            0.4, 10.6, 0, 11.4, 5.2, 113.1, 12.9, 70.2, 12.8, 0.1, 27.0, 883.6, 199.4, 13.1, 8.6, 384.8, 429.3, 73.0, 335.6, 0.3, 60.0, 21.8, 39.5,
            208.9, 408.8, 537.6, 222.9, 170.2, 219.9, 1501.7, 9.6, 0.8, 0, 0.4, 726.0, 22.4, 44.6, 1.5, 3.8, 331.4, 99.8, 51.0, 1.3, 0, 330.8,
            1376.1, 87.9, 65.2, 2.9, 560.8, 711.8, 0, 9.2, 56.0, 458.7, 5.1, 0.4, 22.6, 40.5, 854.3, 39.4, 0.1, 26.7, 112.5, 395.0, 2747.8, 20562.6,
            54.0, 66.5, 0.9, 0, 229.4, 27.4, 24.8, 25.8}
    Public arraysize As Integer = Population.Length - 1
    Public Density(arraysize) As Decimal  ''size是最后面那个数的坐标
    Public GNPPerCapita(arraysize) As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newarray(Density, GNPPerCapita, Population, SurfaceArea, GNP)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            showdata(Country, Capital, Currency, Language, Population, SurfaceArea, Density, GNP, GNPPerCapita)
            RadioButton1.Checked = False
        End If
        If RadioButton2.Checked = True Then
            findlanguage(Country, Language, "English")
            RadioButton2.Checked = False
        End If
        If RadioButton3.Checked = True Then
            findlanguage(Country, Language, "Spanish")
            RadioButton3.Checked = False
        End If
        If RadioButton5.Checked = True Then
            findcurrency(Country, Currency, "U.S. Dollar")
            RadioButton5.Checked = False
        End If
        If RadioButton4.Checked = True Then
            findcurrency(Country, Currency, "Euro")
            RadioButton4.Checked = False
        End If
        If RadioButton7.Checked = True Then
            Dim ChooseCountry As String
            ChooseCountry = InputBox("choose a  country you want to know the capital and currency ")
            querycapitalandcurrency(Capital, Country, Currency, ChooseCountry)
            RadioButton7.Checked = False
        End If
        If RadioButton6.Checked = True Then
            Dim ChooseCountry As String
            ChooseCountry = InputBox("choose a  country you want to know the population, area and GNP ")
            querypopulationareaandGNP(Population, Country, SurfaceArea, GNP, ChooseCountry)
            RadioButton6.Checked = False
        End If
        If RadioButton9.Checked = True Then
            findmost(Population, Country, "million people", "population")
            findmin(Population, Country, "million people", "population")
            findave(Population, Country, "million people", "population")
            RadioButton9.Checked = False
        End If
        If RadioButton8.Checked = True Then
            findmost(Density, Country, "per square kilomenter ", "population density")
            findmin(Density, Country, "per square kilomenter ", "population density")
            findave(Density, Country, "per square kilomenter ", "population density")
            RadioButton8.Checked = False
        End If
        If RadioButton10.Checked = True Then
            findmost(SurfaceArea, Country, "square kilometer", "surfacearea")
            findmin(SurfaceArea, Country, "square kilometer", "surfacearea")
            findave(SurfaceArea, Country, "square kilometer", "surfacearea")
            RadioButton10.Checked = False
        End If
        If RadioButton11.Checked = True Then
            findmostgnp(GNP, Country, "billions", "GNP")
            findmingnp(GNP, Country, "billions", "GNP")
            findavegnp(GNP, Country, "billions", "GNP")
            RadioButton11.Checked = False
        End If
        If RadioButton12.Checked = True Then
            findmostgnp(GNPPerCapita, Country, "per capita", "GNP per capita")
            findmingnp(GNPPerCapita, Country, "per capita", "GNP per capita")
            findavegnp(GNPPerCapita, Country, "per capita", "GNP per capita")
            RadioButton12.Checked = False
        End If


    End Sub


    Sub findlanguage(ByVal Country() As String, ByVal Language() As String, ByVal ChooseLanguage As String)
        ListBox1.Visible = True
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Countries Speaking" & " " & ChooseLanguage)
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add(" ")
        Dim count = 0
        For Postion = 0 To Country.Length - 1
            If Language(Postion) = ChooseLanguage Then
                count = count + 1
                ListBox1.Items.Add(Country(Postion))
            End If
        Next
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add(" ")

        ListBox1.Items.Add(ChooseLanguage & " is spoken in" & count & "countries")
    End Sub


    Sub findcurrency(ByVal Country() As String, ByVal Currency() As String, ByVal ChooseCurrency As String)
        ListBox1.Visible = True
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Countries using" & " " & ChooseCurrency)
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add(" ")
        Dim count = 0
        For Postion = 0 To Country.Length - 1
            If Currency(Postion) = ChooseCurrency Then
                count = count + 1
                ListBox1.Items.Add(Country(Postion))
            End If
        Next
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add(" ")

        ListBox1.Items.Add(count & "Countries use" & ChooseCurrency)
    End Sub
    Sub querycapitalandcurrency(ByVal Captial() As String, ByVal Country() As String, ByVal Currency() As String, ByVal ChooseCountry As String)
        ListBox1.Visible = True
        ListBox1.Items.Clear()
        For Postion = 0 To Country.Length - 1
            If Country(Postion) = ChooseCountry Then
                ListBox1.Items.Add("the captial of " & ChooseCountry & " is " & Capital(Postion) & " and the currency is " & Currency(Postion))
            End If
        Next

    End Sub

    Sub querypopulationareaandGNP(ByVal population() As Decimal, ByVal Country() As String, ByVal area() As Decimal, ByVal GNP() As Decimal, ByVal ChooseCountry As String)
        ListBox1.Visible = True
        ListBox1.Items.Clear()
        For Postion = 0 To Country.Length - 1
            If Country(Postion) = ChooseCountry Then
                ListBox1.Items.Add("the population of " & ChooseCountry & " is " & population(Postion) & "million people and the area is " & area(Postion) & "kilometer squares and the GNP is " & GNP(Postion).ToString("C") & "billions ")
            End If
        Next

    End Sub
    Sub findmost(ByVal population() As Decimal, ByVal Country() As String, ByVal choosewhat As String, ByVal name As String)
        ListBox1.Items.Clear()
        ListBox1.Items.Add(name)
        Dim max As Decimal = 0
        Dim maxcountry As String
        For postion = 0 To population.Length - 1
            If population(postion) > max Then
                max = population(postion)
                maxcountry = Country(postion)
            End If
        Next
        ListBox1.Items.Add(maxcountry & " has the largest " & name & " with " & max.ToString("n0") & choosewhat)

    End Sub
    Sub findmin(ByVal population() As Decimal, ByVal Country() As String, ByVal choosewhat As String, ByVal name As String)

        Dim min As Decimal = 999999999999999
        Dim mincountry As String
        For postion = 0 To population.Length - 1
            If population(postion) <> 0 Then
                If population(postion) < min Then
                    min = population(postion)
                    mincountry = Country(postion)
                End If
            End If

        Next
        ListBox1.Items.Add(mincountry & " has the smallest " & name & " with " & min.ToString("n2") & choosewhat)

    End Sub
    Sub findave(ByVal population() As Decimal, ByVal Country() As String, ByVal choosewhat As String, ByVal name As String)

        Dim sum As Decimal = 0
        Dim result As Decimal
        For postion = 0 To population.Length - 1
            sum = sum + population(postion)
        Next
        result = sum / population.Length
        ListBox1.Items.Add("The average " & name & " of the coutries of the world is " & result.ToString("n0") & choosewhat)

    End Sub
    Sub findmostgnp(ByVal population() As Decimal, ByVal Country() As String, ByVal choosewhat As String, ByVal name As String)
        ListBox1.Items.Clear()
        ListBox1.Items.Add(name)
        Dim max As Decimal = 0
        Dim maxcountry As String
        For postion = 0 To population.Length - 1
            If population(postion) > max Then
                max = population(postion)
                maxcountry = Country(postion)
            End If
        Next
        ListBox1.Items.Add(maxcountry & " has the largest " & name & " with " & max.ToString("C") & choosewhat)

    End Sub
    Sub findmingnp(ByVal population() As Decimal, ByVal Country() As String, ByVal choosewhat As String, ByVal name As String)

        Dim min As Decimal = 999999999999999
        Dim mincountry As String
        For postion = 0 To population.Length - 1
            If population(postion) <> 0 Then
                If population(postion) < min Then
                    min = population(postion)
                    mincountry = Country(postion)
                End If
            End If

        Next
        ListBox1.Items.Add(mincountry & " has the smallest " & name & " with " & min.ToString("C") & choosewhat)

    End Sub
    Sub findavegnp(ByVal population() As Decimal, ByVal Country() As String, ByVal choosewhat As String, ByVal name As String)

        Dim sum As Decimal = 0
        Dim result As Decimal
        For postion = 0 To population.Length - 1
            sum = sum + population(postion)
        Next
        result = sum / population.Length
        ListBox1.Items.Add("The average " & name & " of the coutries of the world is " & result.ToString("C") & choosewhat)

    End Sub

    Sub showdata(ByVal Country() As String, ByVal Capital() As String, ByVal Currency() As String, ByVal language() As String, ByVal Population() As Decimal, ByVal SurfaceArea() As Decimal, ByVal Density() As Decimal, ByVal GNP() As Decimal, ByVal GNPPerCapita() As Decimal)
        ListBox1.Visible = False
        ListView1.Visible = True
        With ListView1
            .View = View.Details
            .Columns.Add("Country", 180)
            .Columns.Add("Capital", 180)
            .Columns.Add("Currency", 180)
            .Columns.Add("First Language", 180)
            .Columns.Add("Population (Millions)", 180)
            .Columns.Add("Surface area  (Sq. km)", 180)

            .Columns.Add("Population density", 180)
            .Columns.Add("GNP (billions)", 180)
            .Columns.Add("Gross national income per capita", 120)
        End With
        For Position = 0 To SurfaceArea.Length - 1
            ListView1.Items.Add(New ListViewItem({Country(Position), Capital(Position), Currency(Position), language(Position), Population(Position).ToString("n1"), SurfaceArea(Position), Density(Position).ToString("n2"), GNP(Position).ToString("C"), GNPPerCapita(Position).ToString("C")}))
        Next
    End Sub
    Sub newarray(ByRef Density() As Decimal, ByRef GNPPerCapita() As Decimal, ByVal Population() As Decimal, ByVal SurfaceArea() As Decimal, ByVal GNP() As Decimal)
        For Position = 0 To SurfaceArea.Length - 1
            If SurfaceArea(Position) = 0 Then
                Density(Position) = 0
            Else
                Density(Position) = Population(Position) * 1000000 / SurfaceArea(Position)
            End If
            If Population(Position) = 0 Then
                GNPPerCapita(Position) = 0
            Else
                GNPPerCapita(Position) = GNP(Position) * 1000 / Population(Position)
            End If
        Next
    End Sub

End Class
