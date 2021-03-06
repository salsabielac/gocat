USE [cat]
GO
/****** Object:  Table [dbo].[agama]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[agama](
	[id_agama] [int] NOT NULL,
	[keterangan] [varchar](10) NOT NULL,
 CONSTRAINT [PK_agama] PRIMARY KEY CLUSTERED 
(
	[id_agama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[akun]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[akun](
	[id_pelanggan] [int] NOT NULL,
	[id_kucing] [int] NOT NULL,
	[nama] [varchar](30) NOT NULL,
	[id_jk] [int] NULL,
	[id_agama] [int] NULL,
	[alamat] [varchar](50) NOT NULL,
	[telp] [nvarchar](12) NOT NULL,
	[email] [varchar](40) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_akun] PRIMARY KEY CLUSTERED 
(
	[id_pelanggan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clean]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clean](
	[id_clean] [int] NOT NULL,
	[id_pelanggan] [int] NOT NULL,
	[id_kucing] [int] NOT NULL,
	[id_karyawan] [int] NOT NULL,
	[id_jperawatan] [int] NOT NULL,
	[harga] [int] NOT NULL,
	[id_driver] [int] NOT NULL,
 CONSTRAINT [PK_clean] PRIMARY KEY CLUSTERED 
(
	[id_clean] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dokter]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dokter](
	[id_dokter] [int] NOT NULL,
	[nama] [varchar](30) NOT NULL,
	[id_agama] [int] NULL,
	[id_jk] [int] NULL,
	[alamat] [varchar](50) NOT NULL,
	[telp] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_dokter] PRIMARY KEY CLUSTERED 
(
	[id_dokter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[driver]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[driver](
	[id_driver] [int] NOT NULL,
	[nama] [varchar](30) NOT NULL,
	[alamat] [varchar](50) NOT NULL,
	[telp] [nvarchar](12) NOT NULL,
	[id_agama] [int] NULL,
	[id_jk] [int] NULL,
 CONSTRAINT [PK_driver] PRIMARY KEY CLUSTERED 
(
	[id_driver] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[food]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[food](
	[id_food] [int] NOT NULL,
	[id_pelanggan] [int] NOT NULL,
	[id_driver] [int] NOT NULL,
	[nama] [varchar](30) NOT NULL,
	[id_jmakanan] [int] NOT NULL,
	[jumlah] [int] NOT NULL,
	[harga] [int] NOT NULL,
 CONSTRAINT [PK_food] PRIMARY KEY CLUSTERED 
(
	[id_food] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[harga]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[harga](
	[id_harga] [int] NOT NULL,
	[keterangan] [varchar](50) NOT NULL,
	[tanggal] [datetime] NOT NULL,
	[harga] [int] NOT NULL,
 CONSTRAINT [PK_harga] PRIMARY KEY CLUSTERED 
(
	[id_harga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[health]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[health](
	[id_health] [int] NOT NULL,
	[id_pelanggan] [int] NOT NULL,
	[id_kucing] [int] NOT NULL,
	[id_dokter] [int] NOT NULL,
	[id_jhealth] [int] NOT NULL,
	[harga] [int] NOT NULL,
 CONSTRAINT [PK_health] PRIMARY KEY CLUSTERED 
(
	[id_health] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[jeniskelamin]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jeniskelamin](
	[id_jk] [int] NOT NULL,
	[keterangan] [varchar](10) NOT NULL,
 CONSTRAINT [PK_jeniskelamin] PRIMARY KEY CLUSTERED 
(
	[id_jk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[jeniskesehatan]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jeniskesehatan](
	[id_jhealth] [int] NOT NULL,
	[keterangan] [varchar](50) NOT NULL,
 CONSTRAINT [PK_jeniskesehatan] PRIMARY KEY CLUSTERED 
(
	[id_jhealth] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[jeniskucing]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jeniskucing](
	[id_jkucing] [int] NOT NULL,
	[keterangan] [varchar](20) NOT NULL,
 CONSTRAINT [PK_jeniskucing] PRIMARY KEY CLUSTERED 
(
	[id_jkucing] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[jenismakanan]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jenismakanan](
	[id_jmakanan] [int] NOT NULL,
	[keterangan] [varchar](20) NOT NULL,
	[harga] [int] NOT NULL,
 CONSTRAINT [PK_jenismakanan] PRIMARY KEY CLUSTERED 
(
	[id_jmakanan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[jenispelayanan]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jenispelayanan](
	[id_jenis] [int] NOT NULL,
	[keterangan] [varchar](50) NOT NULL,
 CONSTRAINT [PK_jenispelayanan] PRIMARY KEY CLUSTERED 
(
	[id_jenis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[jenisperawatan]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jenisperawatan](
	[id_jperawatan] [int] NOT NULL,
	[keterangan] [varchar](30) NOT NULL,
	[id_harga] [int] NOT NULL,
 CONSTRAINT [PK_jenisperawatan] PRIMARY KEY CLUSTERED 
(
	[id_jperawatan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[karyawan]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[karyawan](
	[id_karyawan] [int] NOT NULL,
	[nama] [varchar](30) NOT NULL,
	[alamat] [varchar](50) NOT NULL,
	[telp] [nvarchar](12) NOT NULL,
	[id_agama] [int] NOT NULL,
	[id_jk] [int] NOT NULL,
 CONSTRAINT [PK_karyawan] PRIMARY KEY CLUSTERED 
(
	[id_karyawan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kucing]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kucing](
	[id_kucing] [int] NOT NULL,
	[nama] [varchar](20) NOT NULL,
	[id_jkucing] [int] NOT NULL,
	[id_jk] [int] NOT NULL,
	[usia] [int] NOT NULL,
 CONSTRAINT [PK_kucing] PRIMARY KEY CLUSTERED 
(
	[id_kucing] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pembayaran]    Script Date: 12/14/2016 4:38:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pembayaran](
	[id_pembayaran] [int] NOT NULL,
	[id_pelanggan] [int] NULL,
	[id_jenis] [int] NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_pembayaran] PRIMARY KEY CLUSTERED 
(
	[id_pembayaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[akun]  WITH CHECK ADD  CONSTRAINT [FK_akun_agama] FOREIGN KEY([id_agama])
REFERENCES [dbo].[agama] ([id_agama])
GO
ALTER TABLE [dbo].[akun] CHECK CONSTRAINT [FK_akun_agama]
GO
ALTER TABLE [dbo].[akun]  WITH CHECK ADD  CONSTRAINT [FK_akun_jeniskelamin] FOREIGN KEY([id_jk])
REFERENCES [dbo].[jeniskelamin] ([id_jk])
GO
ALTER TABLE [dbo].[akun] CHECK CONSTRAINT [FK_akun_jeniskelamin]
GO
ALTER TABLE [dbo].[akun]  WITH CHECK ADD  CONSTRAINT [FK_akun_kucing] FOREIGN KEY([id_kucing])
REFERENCES [dbo].[kucing] ([id_kucing])
GO
ALTER TABLE [dbo].[akun] CHECK CONSTRAINT [FK_akun_kucing]
GO
ALTER TABLE [dbo].[clean]  WITH CHECK ADD  CONSTRAINT [FK_clean_akun] FOREIGN KEY([id_pelanggan])
REFERENCES [dbo].[akun] ([id_pelanggan])
GO
ALTER TABLE [dbo].[clean] CHECK CONSTRAINT [FK_clean_akun]
GO
ALTER TABLE [dbo].[clean]  WITH CHECK ADD  CONSTRAINT [FK_clean_driver] FOREIGN KEY([id_driver])
REFERENCES [dbo].[driver] ([id_driver])
GO
ALTER TABLE [dbo].[clean] CHECK CONSTRAINT [FK_clean_driver]
GO
ALTER TABLE [dbo].[clean]  WITH CHECK ADD  CONSTRAINT [FK_clean_jenisperawatan] FOREIGN KEY([id_jperawatan])
REFERENCES [dbo].[jenisperawatan] ([id_jperawatan])
GO
ALTER TABLE [dbo].[clean] CHECK CONSTRAINT [FK_clean_jenisperawatan]
GO
ALTER TABLE [dbo].[clean]  WITH CHECK ADD  CONSTRAINT [FK_clean_karyawan] FOREIGN KEY([id_karyawan])
REFERENCES [dbo].[karyawan] ([id_karyawan])
GO
ALTER TABLE [dbo].[clean] CHECK CONSTRAINT [FK_clean_karyawan]
GO
ALTER TABLE [dbo].[clean]  WITH CHECK ADD  CONSTRAINT [FK_clean_kucing] FOREIGN KEY([id_kucing])
REFERENCES [dbo].[kucing] ([id_kucing])
GO
ALTER TABLE [dbo].[clean] CHECK CONSTRAINT [FK_clean_kucing]
GO
ALTER TABLE [dbo].[dokter]  WITH CHECK ADD  CONSTRAINT [FK_dokter_agama] FOREIGN KEY([id_agama])
REFERENCES [dbo].[agama] ([id_agama])
GO
ALTER TABLE [dbo].[dokter] CHECK CONSTRAINT [FK_dokter_agama]
GO
ALTER TABLE [dbo].[driver]  WITH CHECK ADD  CONSTRAINT [FK_driver_agama] FOREIGN KEY([id_agama])
REFERENCES [dbo].[agama] ([id_agama])
GO
ALTER TABLE [dbo].[driver] CHECK CONSTRAINT [FK_driver_agama]
GO
ALTER TABLE [dbo].[driver]  WITH CHECK ADD  CONSTRAINT [FK_driver_jeniskelamin] FOREIGN KEY([id_jk])
REFERENCES [dbo].[jeniskelamin] ([id_jk])
GO
ALTER TABLE [dbo].[driver] CHECK CONSTRAINT [FK_driver_jeniskelamin]
GO
ALTER TABLE [dbo].[food]  WITH CHECK ADD  CONSTRAINT [FK_food_akun] FOREIGN KEY([id_pelanggan])
REFERENCES [dbo].[akun] ([id_pelanggan])
GO
ALTER TABLE [dbo].[food] CHECK CONSTRAINT [FK_food_akun]
GO
ALTER TABLE [dbo].[food]  WITH CHECK ADD  CONSTRAINT [FK_food_driver] FOREIGN KEY([id_driver])
REFERENCES [dbo].[driver] ([id_driver])
GO
ALTER TABLE [dbo].[food] CHECK CONSTRAINT [FK_food_driver]
GO
ALTER TABLE [dbo].[food]  WITH CHECK ADD  CONSTRAINT [FK_food_jenismakanan] FOREIGN KEY([id_jmakanan])
REFERENCES [dbo].[jenismakanan] ([id_jmakanan])
GO
ALTER TABLE [dbo].[food] CHECK CONSTRAINT [FK_food_jenismakanan]
GO
ALTER TABLE [dbo].[health]  WITH CHECK ADD  CONSTRAINT [FK_health_akun] FOREIGN KEY([id_pelanggan])
REFERENCES [dbo].[akun] ([id_pelanggan])
GO
ALTER TABLE [dbo].[health] CHECK CONSTRAINT [FK_health_akun]
GO
ALTER TABLE [dbo].[health]  WITH CHECK ADD  CONSTRAINT [FK_health_akun1] FOREIGN KEY([id_pelanggan])
REFERENCES [dbo].[akun] ([id_pelanggan])
GO
ALTER TABLE [dbo].[health] CHECK CONSTRAINT [FK_health_akun1]
GO
ALTER TABLE [dbo].[health]  WITH CHECK ADD  CONSTRAINT [FK_health_dokter] FOREIGN KEY([id_dokter])
REFERENCES [dbo].[dokter] ([id_dokter])
GO
ALTER TABLE [dbo].[health] CHECK CONSTRAINT [FK_health_dokter]
GO
ALTER TABLE [dbo].[health]  WITH CHECK ADD  CONSTRAINT [FK_health_jeniskesehatan] FOREIGN KEY([id_jhealth])
REFERENCES [dbo].[jeniskesehatan] ([id_jhealth])
GO
ALTER TABLE [dbo].[health] CHECK CONSTRAINT [FK_health_jeniskesehatan]
GO
ALTER TABLE [dbo].[health]  WITH CHECK ADD  CONSTRAINT [FK_health_kucing] FOREIGN KEY([id_kucing])
REFERENCES [dbo].[kucing] ([id_kucing])
GO
ALTER TABLE [dbo].[health] CHECK CONSTRAINT [FK_health_kucing]
GO
ALTER TABLE [dbo].[jenisperawatan]  WITH CHECK ADD  CONSTRAINT [FK_jenisperawatan_harga] FOREIGN KEY([id_harga])
REFERENCES [dbo].[harga] ([id_harga])
GO
ALTER TABLE [dbo].[jenisperawatan] CHECK CONSTRAINT [FK_jenisperawatan_harga]
GO
ALTER TABLE [dbo].[karyawan]  WITH CHECK ADD  CONSTRAINT [FK_karyawan_jeniskelamin] FOREIGN KEY([id_jk])
REFERENCES [dbo].[jeniskelamin] ([id_jk])
GO
ALTER TABLE [dbo].[karyawan] CHECK CONSTRAINT [FK_karyawan_jeniskelamin]
GO
ALTER TABLE [dbo].[kucing]  WITH CHECK ADD  CONSTRAINT [FK_kucing_jeniskelamin] FOREIGN KEY([id_jk])
REFERENCES [dbo].[jeniskelamin] ([id_jk])
GO
ALTER TABLE [dbo].[kucing] CHECK CONSTRAINT [FK_kucing_jeniskelamin]
GO
ALTER TABLE [dbo].[kucing]  WITH CHECK ADD  CONSTRAINT [FK_kucing_jeniskucing] FOREIGN KEY([id_jkucing])
REFERENCES [dbo].[jeniskucing] ([id_jkucing])
GO
ALTER TABLE [dbo].[kucing] CHECK CONSTRAINT [FK_kucing_jeniskucing]
GO
ALTER TABLE [dbo].[pembayaran]  WITH CHECK ADD  CONSTRAINT [FK_pembayaran_akun] FOREIGN KEY([id_pelanggan])
REFERENCES [dbo].[akun] ([id_pelanggan])
GO
ALTER TABLE [dbo].[pembayaran] CHECK CONSTRAINT [FK_pembayaran_akun]
GO
ALTER TABLE [dbo].[pembayaran]  WITH CHECK ADD  CONSTRAINT [FK_pembayaran_jenispelayanan] FOREIGN KEY([id_jenis])
REFERENCES [dbo].[jenispelayanan] ([id_jenis])
GO
ALTER TABLE [dbo].[pembayaran] CHECK CONSTRAINT [FK_pembayaran_jenispelayanan]
GO
