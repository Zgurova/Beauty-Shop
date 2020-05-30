USE products;

CREATE TABLE creams
(
id VARCHAR(5) PRIMARY KEY,
name VARCHAR(50) ,
price DECIMAL(5,2),
type VARCHAR(50) 
);

CREATE TABLE perfumes
(
id VARCHAR(5) PRIMARY KEY,
name VARCHAR(50) ,
price DECIMAL(5,2),
type VARCHAR(50) 
);

CREATE TABLE makeUp
(
id VARCHAR(5) PRIMARY KEY,
name VARCHAR(50) ,
price DECIMAL(5,2),
type VARCHAR(50) 
);

CREATE TABLE connection
(
 id VARCHAR(5) PRIMARY KEY,
 id_creams VARCHAR(5) ,
 id_perfumes VARCHAR(5),
 id_makeUp VARCHAR(5),
 CONSTRAINT fk_connection_creams FOREIGN KEY(id_creams) REFERENCES creams (id),
 CONSTRAINT fk_connection_perfumes FOREIGN KEY(id_perfumes) REFERENCES perfumes (id),
 CONSTRAINT fk_connection_makeUp FOREIGN KEY(id_makeUp) REFERENCES makeUp (id)
);

CREATE TABLE cart
(
 ID VARCHAR(5) PRIMARY KEY, 
 name VARCHAR(20),
 number_of_orders INT,
 price DECIMAL(5,2),
 totalPrice DECIMAL
);

INSERT INTO perfumes(id, name, price, type) VALUES
('0000','La Vie Est Belle', 132.00,'ladies'),
('0001','Quatre', 65.90, 'ladies'),
('0002','for Her', 41.90, 'ladies'),
('0003','Euphoria', 69.90, 'ladies'),
('0004','Be Delicious', 59.90, 'ladies'),
('0005','Wish', 47.90, 'ladies'),
('0006','La Nuit Tresor', 139.00, 'ladies'),
('0007','Si', 119.00, 'ladies'),
('0008', 'Eternity', 46.90, 'ladies'),
('0009','Idole', 159.00, 'ladies'),
('0010','Crystal Noir', 98.00, 'ladies'),
('0011', 'Alien', 118.70, 'ladies'),
('0012', 'Black Opium', 146.00, 'ladies'),
('0013', 'Womanity', 109.00, 'ladies'),
('0014', 'Nomade', 124.10, 'ladies'),
('0015', 'Scandal', 155.50, 'ladies'),
('0016', 'Chloe', 115.60, 'ladies'),
('0017', 'Passenger for Women', 45.90, 'ladies'),
('0018', 'BOSS Ma Vie', 75.00, 'ladies'),
('0019', 'Bloom', 139.00, 'ladies'),
('0020', 'Olympea', 139.00, 'ladies'),
('0021', 'Quatre', 65.90, 'ladies'),
('0022', 'Be Delicious', 59.90, 'ladies'),
('0023', 'Le Petite Robe Noire', 86.10, 'ladies'),
('0024', 'Emporio Stronger With You', 72.00, 'male'),
('0025', 'Emporio Stronger With You Intensely', 83.70, 'male'),
('0026', 'AQVA Pour Homme', 42.20, 'male'),
('0027', 'Encre Noire for Men', 36.00, 'male'),
('0028', 'Invictus', 102.70, 'male'),
('0029', 'Terre di Hermes', 138.00, 'male'),
('0030', 'Eros', 70.20, 'male'),
('0031', 'Sauvage', 132.00, 'male'),
('0032', '1 Million', 93.00, 'male'),
('0033', 'BOSS Bottled', 41.90, 'male'),
('0034', 'Chrome', 45.70, 'male'),
('0035', 'Acqua di Gio Pour Hommes', 80.40, 'male'),
('0036', 'BOSS The Scent', 72.60, 'male'),
('0037', 'Code', 75.90, 'male'),
('0038', 'The One for Men', 113.40, 'male'),
('0039', 'Explorer', 59.60, 'male'),
('0040', 'Man Eau Fraiche', 56.00, 'male'),
('0041', 'Acqua di Gio Profumo', 99.00, 'male'),
('0042', '212 NYC Men', 66.30, 'male'),
('0043', 'BOSS The Scent Private Accord', 72.90, 'male'),
('0044', 'Y', 141.90, 'male'),
('0045', 'Invictus Legend', 121.90, 'male');

INSERT INTO creams(id, name, price, type) VALUES
('000','Clinique', 151.30,'ladies'),
('001','Estée Lauder', 165.10, 'ladies'),
('002','La Mer', 43.30, 'ladies'),
('003','Shiseido', 79.90, 'ladies'),
('004','Clinique Moisture', 59.40, 'ladies'),
('005','La Mer Moisturizers', 57.30, 'ladies'),
('006','Shiseido Benefiance', 159.20, 'ladies'),
('007','Estée Lauder', 139.30, 'ladies'),
('008', 'Dior Hydra', 144.90, 'ladies'),
('009','Revitalizing Supreme', 59.10, 'ladies'),
('010','Moisturizers', 83.30, 'ladies'),
('011', 'La Roche-Posay', 182.00, 'ladies'),
('012', 'La Prairie', 143.00, 'ladies'),
('013', 'Visionnaire', 169.00, 'ladies'),
('014', 'Clinique 3 Steps', 14.10, 'ladies'),
('015', 'Clinique Smart', 50.70, 'ladies'),
('016', 'La Mer Genaissance', 115.60, 'ladies'),
('017', 'La Prairie Anti-Aging', 45.90, 'ladies'),
('018', 'Filorga Oxygen-Glow', 75.00, 'ladies'),
('019', 'La Prairie Anti-Aging', 139.40, 'ladies'),
('020', 'Lancôme Génifique', 179.60, 'ladies'),
('021', 'Lierac Arkéskin+', 165.70, 'ladies'),
('022', 'Re-Nutriv Ultimate', 50.80, 'ladies'),
('023', 'Resilience Lift Night', 136.60, 'ladies'),
('024', 'Rénergie Multi-Lift Ultra', 122.00, 'male'),
('025', 'Embryolisse', 33.70, 'male'),
('026', 'Embryolisse Moisturizers', 32.20, 'male'),
('027', 'La Mer Skincolor', 156.60, 'male'),
('028', 'Shiseido Bio-Performance', 172.30, 'male'),
('029', 'Lancôme Absolue', 38.30, 'male'),
('030', ' Rénergie Nuit Multi-Lift', 20.30, 'male'),
('031', 'Dior Capture Totale', 62.30, 'male'),
('032', 'L’Oréal', 53.00, 'male'),
('033', 'L’Oréal Professionnel', 102.90, 'male'),
('034', 'Steampod', 136.70, 'male'),
('035', 'NightWear Plus', 50.40, 'male'),
('036', 'Clarins Hydra-Essentiel', 72.60, 'male'),
('037', 'Vichy Liftactiv', 65.90, 'male'),
('038', ' Liftactiv Supreme', 19.40, 'male'),
('039', 'Cream Hand & Nails', 109.60, 'male'),
('040', 'Clinique Pep-Start', 25.50, 'male'),
('041', 'Pep-Start', 109.00, 'male'),
('042', 'Bioderma Atoderm', 156.30, 'male'),
('043', 'Atoderm Cream', 102.40, 'male'),
('044', 'Vichy Liftactiv', 41.50, 'male'),
('045', 'Mythic Oil', 101.00, 'male');

INSERT INTO makeUp(id, name, price, type) VALUES
('1111','Fortune Favours the Brave', 15.90,'ladies'),
('0011','Reloaded', 6.90, 'ladies'),
('0022','Conceal & Define', 41.90, 'ladies'),
('0033','Baking Powder', 39.90, 'ladies'),
('0044','Flawless 4', 30.90, 'ladies'),
('0055','Focus & Fix', 47.90, 'ladies'),
('0066','Soph X', 39.00, 'ladies'),
('0077','Ultra Sculpt & Contour', 19.00, 'ladies'),
('0088', 'Cheek Kit', 6.90, 'ladies'),
('0099','X Alexis Stone', 50.00, 'ladies'),
('0110','Soph X Totally Soph', 17.00, 'ladies'),
('0111', 'Brushes', 18.70, 'ladies'),
('0122', 'Forever Flawless', 46.00, 'ladies'),
('0133', 'Soft Matte Lip Cream', 19.00, 'ladies'),
('0144', 'High Definition ', 14.10, 'ladies'),
('0155', 'Studio Photogenic', 15.50, 'ladies'),
('0166', 'Ultimate Shadow', 15.60, 'ladies'),
('0177', 'Pore Filler', 45.90, 'ladies'),
('0188', 'Ultra Contour', 17.00, 'ladies'),
('0199', 'Ultra Flawless 3', 19.00, 'ladies'),
('0220', 'Renaissance Illuminate', 19.00, 'ladies'),
('0211', 'Liquid Highlighter', 65.90, 'ladies'),
('0222', 'Ultimate Edit', 9.90, 'ladies'),
('0233', 'Petite Shadow', 16.10, 'ladies'),
('0244', 'Tammi Tropical Carnival', 12.00, 'ladies'),
('0255', 'Imogenation', 13.70, 'ladies'),
('0266', 'Halloween Glitter', 22.20, 'ladies'),
('0277', 'Bake & Blot', 36.00, 'ladies'),
('0288', 'Slim Lip Pencil', 12.70, 'ladies'),
('0299', 'Control Freak', 18.00, 'ladies'),
('0330', 'Mega Bronzer', 40.20, 'ladies'),
('0311', 'Contour Cream PRO', 12.00, 'ladies'),
('0322', 'Jewel Collection', 33.00, 'ladies'),
('0333', 'Revolution Matte Base', 40.90, 'ladies'),
('0344', 'Be In Love With', 5.270, 'ladies'),
('0355', 'Studio Perfect Primer', 20.40, 'ladies'),
('0366', 'Nudes Collection', 32.60, 'ladies'),
('0377', 'Wonder Stick', 25.90, 'ladies'),
('0388', 'Micro Brow Pencil', 11.40, 'ladies'),
('0399', 'Retro Luxe', 39.60, 'ladies'),
('0440', 'Face Quad', 26.00, 'ladies'),
('0411', 'thisiseverything', 9.00, 'ladies'),
('0422', 'Makeup', 16.30, 'ladies'),
('0433', 'Micro Brow', 7.90, 'ladies'),
('0444', 'Brow Pencil', 11.20, 'ladies'),
('0455', 'Jewel', 11.90, 'ladies');