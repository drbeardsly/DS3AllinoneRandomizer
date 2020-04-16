using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;

namespace pooremma
{
	internal class RandomizerForEnemy
	{
		public static string[] FILE_NAME;

		private readonly static string[] LIST_FILE_RANDOM_DS3;

		private readonly static string[] EVENT_DS3;

		private readonly static string[] EVENT_WRITE;

		private readonly static string[] LIST_FILE_RANDOM_WRITE;

		private readonly static string[] LIST_BOSS;

		static RandomizerForEnemy()
		{
			RandomizerForEnemy.FILE_NAME = new string[] { "EnemyData\\NormalEnemyName.txt", "EnemyData\\BossName.txt", "EnemyData\\AllEnemyName.txt" };
			RandomizerForEnemy.LIST_FILE_RANDOM_DS3 = new string[] { "files\\mapstudio\\m30_00_00_00.msb.dcx", "files\\mapstudio\\m30_01_00_00.msb.dcx", "files\\mapstudio\\m31_00_00_00.msb.dcx", "files\\mapstudio\\m32_00_00_00.msb.dcx", "files\\mapstudio\\m33_00_00_00.msb.dcx", "files\\mapstudio\\m34_01_00_00.msb.dcx", "files\\mapstudio\\m35_00_00_00.msb.dcx", "files\\mapstudio\\m37_00_00_00.msb.dcx", "files\\mapstudio\\m38_00_00_00.msb.dcx", "files\\mapstudio\\m39_00_00_00.msb.dcx", "files\\mapstudio\\m40_00_00_00.msb.dcx", "files\\mapstudio\\m41_00_00_00.msb.dcx", "files\\mapstudio\\m45_00_00_00.msb.dcx", "files\\mapstudio\\m50_00_00_00.msb.dcx", "files\\mapstudio\\m51_00_00_00.msb.dcx", "files\\mapstudio\\m51_01_00_00.msb.dcx" };
			RandomizerForEnemy.EVENT_DS3 = new string[] { "files\\event\\m30_00_00_00.emevd.dcx", "files\\event\\m30_01_00_00.emevd.dcx", "files\\event\\m31_00_00_00.emevd.dcx", "files\\event\\m32_00_00_00.emevd.dcx", "files\\event\\m33_00_00_00.emevd.dcx", "files\\event\\m34_01_00_00.emevd.dcx", "files\\event\\m35_00_00_00.emevd.dcx", "files\\event\\m37_00_00_00.emevd.dcx", "files\\event\\m38_00_00_00.emevd.dcx", "files\\event\\m39_00_00_00.emevd.dcx", "files\\event\\m40_00_00_00.emevd.dcx", "files\\event\\m41_00_00_00.emevd.dcx", "files\\event\\m45_00_00_00.emevd.dcx", "files\\event\\m50_00_00_00.emevd.dcx", "files\\event\\m51_00_00_00.emevd.dcx", "files\\event\\m51_01_00_00.emevd.dcx" };
			RandomizerForEnemy.EVENT_WRITE = new string[] { "event\\m30_00_00_00.emevd.dcx", "event\\m30_01_00_00.emevd.dcx", "event\\m31_00_00_00.emevd.dcx", "event\\m32_00_00_00.emevd.dcx", "event\\m33_00_00_00.emevd.dcx", "event\\m34_01_00_00.emevd.dcx", "event\\m35_00_00_00.emevd.dcx", "event\\m37_00_00_00.emevd.dcx", "event\\m38_00_00_00.emevd.dcx", "event\\m39_00_00_00.emevd.dcx", "event\\m40_00_00_00.emevd.dcx", "event\\m41_00_00_00.emevd.dcx", "event\\m45_00_00_00.emevd.dcx", "event\\m50_00_00_00.emevd.dcx", "event\\m51_00_00_00.emevd.dcx", "event\\m51_01_00_00.emevd.dcx" };
			RandomizerForEnemy.LIST_FILE_RANDOM_WRITE = new string[] { "map\\mapstudio\\m30_00_00_00.msb.dcx", "map\\mapstudio\\m30_01_00_00.msb.dcx", "map\\mapstudio\\m31_00_00_00.msb.dcx", "map\\mapstudio\\m32_00_00_00.msb.dcx", "map\\mapstudio\\m33_00_00_00.msb.dcx", "map\\mapstudio\\m34_01_00_00.msb.dcx", "map\\mapstudio\\m35_00_00_00.msb.dcx", "map\\mapstudio\\m37_00_00_00.msb.dcx", "map\\mapstudio\\m38_00_00_00.msb.dcx", "map\\mapstudio\\m39_00_00_00.msb.dcx", "map\\mapstudio\\m40_00_00_00.msb.dcx", "map\\mapstudio\\m41_00_00_00.msb.dcx", "map\\mapstudio\\m45_00_00_00.msb.dcx", "map\\mapstudio\\m50_00_00_00.msb.dcx", "map\\mapstudio\\m51_00_00_00.msb.dcx", "map\\mapstudio\\m51_01_00_00.msb.dcx" };
			RandomizerForEnemy.LIST_BOSS = new string[] { "c5110_0000", "c2240_0000", "c3040_0000", "c1320_0000", "c5220_0000", "c5180_0000", "c5251_0000", "c5250_0000", "c6010_0000", "c5160_0000", "c3050_0000", "c5140_0000", "c5150_0001", "c3140_0003", "c3140_0000", "c2200_0000", "c3140_0001", "c5260_0000", "c5270_0001", "c2090_0000", "c5110_0001", "c3160_0000", "c5250_0001", "c5280_0000", "c5010_0000", "c5030_0000", "c6030_0004", "c6020_0001", "c6020_0000", "c6211_0000", "c6200_0000", "c6201_0000", "c5020_0001", "c5020_0002" };
		}

		public RandomizerForEnemy()
		{
		}

		public static void Randomwriter(int choiceA, int choiceB)
		{
			int num;
			List<RandomizerForEnemy.EnemyData> enemyDatas = new List<RandomizerForEnemy.EnemyData>();
			List<RandomizerForEnemy.EnemyData> enemyDatas1 = new List<RandomizerForEnemy.EnemyData>();
			List<RandomizerForEnemy.EnemyData> enemyDatas2 = new List<RandomizerForEnemy.EnemyData>();
			RandomizerForEnemy.EnemyData enemyDatum = null;
			FileStream fileStream = new FileStream(RandomizerForEnemy.FILE_NAME[0], FileMode.Open, FileAccess.Read);
			StreamReader streamReader = new StreamReader(fileStream);
			while (true)
			{
				string str = streamReader.ReadLine();
				string str1 = str;
				if (str == null)
				{
					break;
				}
				string[] strArrays = str1.Split(new char[] { '\t' });
				enemyDatum = new RandomizerForEnemy.EnemyData()
				{
					EnemyName = strArrays[0],
					EventEntityID = Convert.ToInt32(strArrays[1]),
					ModelName = strArrays[2],
					NPCParamID = Convert.ToInt32(strArrays[3]),
					ThinkParamID = Convert.ToInt32(strArrays[4])
				};
				enemyDatas.Add(enemyDatum);
			}
			streamReader.Close();
			fileStream.Close();
			FileStream fileStream1 = new FileStream(RandomizerForEnemy.FILE_NAME[1], FileMode.Open, FileAccess.Read);
			StreamReader streamReader1 = new StreamReader(fileStream1);
			while (true)
			{
				string str2 = streamReader1.ReadLine();
				string str3 = str2;
				if (str2 == null)
				{
					break;
				}
				string[] strArrays1 = str3.Split(new char[] { '\t' });
				enemyDatum = new RandomizerForEnemy.EnemyData()
				{
					EnemyName = strArrays1[0],
					EventEntityID = Convert.ToInt32(strArrays1[1]),
					ModelName = strArrays1[2],
					NPCParamID = Convert.ToInt32(strArrays1[3]),
					ThinkParamID = Convert.ToInt32(strArrays1[4])
				};
				enemyDatas1.Add(enemyDatum);
			}
			streamReader1.Close();
			fileStream1.Close();
			FileStream fileStream2 = new FileStream(RandomizerForEnemy.FILE_NAME[2], FileMode.Open, FileAccess.Read);
			StreamReader streamReader2 = new StreamReader(fileStream2);
			while (true)
			{
				string str4 = streamReader2.ReadLine();
				string str5 = str4;
				if (str4 == null)
				{
					break;
				}
				string[] strArrays2 = str5.Split(new char[] { '\t' });
				enemyDatum = new RandomizerForEnemy.EnemyData()
				{
					EnemyName = strArrays2[0],
					EventEntityID = Convert.ToInt32(strArrays2[1]),
					ModelName = strArrays2[2],
					NPCParamID = Convert.ToInt32(strArrays2[3]),
					ThinkParamID = Convert.ToInt32(strArrays2[4])
				};
				enemyDatas2.Add(enemyDatum);
			}
			streamReader2.Close();
			fileStream2.Close();
			for (int i = 0; i < (int)RandomizerForEnemy.LIST_FILE_RANDOM_DS3.Length; i++)
			{
				MSB3 mSB3 = SoulsFile<MSB3>.Read(RandomizerForEnemy.LIST_FILE_RANDOM_DS3[i]);
				EMEVD eMEVD = SoulsFile<EMEVD>.Read(RandomizerForEnemy.EVENT_DS3[i]);
				List<EMEVD.Instruction> instructions = eMEVD.Events[0].Instructions;
				List<MSB3.Part.Enemy> enemies = mSB3.Parts.Enemies;
				int num1 = 0;
				Random random = new Random();
				List<RandomizerForEnemy.EnemyData> enemyDatas3 = new List<RandomizerForEnemy.EnemyData>();
				if (choiceA != 0)
				{
					int num2 = random.Next(0, enemyDatas1.Count);
					enemyDatas3.Add(enemyDatas1[num2]);
					for (int j = 0; j < 29; j++)
					{
						int num3 = random.Next(0, enemyDatas.Count);
						enemyDatas3.Add(enemyDatas[num3]);
					}
				}
				else
				{
					for (int k = 0; k < 30; k++)
					{
						int num4 = random.Next(0, enemyDatas.Count);
						enemyDatas3.Add(enemyDatas[num4]);
					}
				}
				for (int l = 0; l < enemies.Count; l++)
				{
					byte[] numArray = new byte[] { 82, 191, 1, 0, 0, 0, 0, 0 };
					byte[] numArray1 = new byte[] { 83, 191, 1, 0, 0, 0, 0, 0 };
					byte[] numArray2 = new byte[] { 84, 191, 1, 0, 0, 0, 0, 0 };
					if ((enemies[l].ModelName == "c6331" || enemies[l].ModelName == "c6121" || enemies[l].ModelName == "c6120" || enemies[l].ModelName == "c2170" || enemies[l].ModelName == "c6310" || enemies[l].ModelName == "c0000" || enemies[l].ModelName == "c0100" || enemies[l].ModelName == "c1400" || enemies[l].ModelName == "c6210" || enemies[l].ModelName == "c2120" || enemies[l].ModelName == "c3190" || enemies[l].ModelName == "c1450" || enemies[l].ModelName == "c3200" || enemies[l].ModelName == "c3250" || enemies[l].ModelName == "c2160" ? false : enemies[l].ModelName != "c1000"))
					{
						if ((enemies[l].EventEntityID == 3100257 || enemies[l].EventEntityID == 3100252 || enemies[l].EventEntityID == 3100266 || enemies[l].EventEntityID == 3100261 || enemies[l].EventEntityID == 4500265 || enemies[l].EventEntityID == 4500264 || enemies[l].EventEntityID == 4500263 || enemies[l].EventEntityID / 100 == 35004 || enemies[l].EventEntityID / 100 == 35008 && enemies[l].EventEntityID != 3500800 || enemies[l].EventEntityID == 3300372 || enemies[l].EventEntityID == 3300373 || enemies[l].EventEntityID == 3000612 || enemies[l].EventEntityID == 3000610 || enemies[l].EventEntityID == 3010568 ? false : enemies[l].EventEntityID != 3010539))
						{
							if ((num1 % 40 != 0 ? false : num1 != 0))
							{
								enemyDatas3.Clear();
								if (choiceA != 0)
								{
									int num5 = random.Next(0, enemyDatas1.Count);
									enemyDatas3.Add(enemyDatas1[num5]);
									for (int m = 0; m < 29; m++)
									{
										num5 = random.Next(0, enemyDatas.Count);
										enemyDatas3.Add(enemyDatas[num5]);
									}
								}
								else
								{
									for (int n = 0; n < 30; n++)
									{
										int num6 = random.Next(0, enemyDatas.Count);
										enemyDatas3.Add(enemyDatas[num6]);
									}
								}
							}
							int num7 = 0;
							while (true)
							{
								if (num7 >= (int)RandomizerForEnemy.LIST_BOSS.Length)
								{
									int num8 = random.Next(0, enemyDatas3.Count);
									enemies[l].ModelName = enemyDatas3[num8].ModelName;
									enemies[l].NPCParamID = enemyDatas3[num8].NPCParamID;
									enemies[l].ThinkParamID = enemyDatas3[num8].ThinkParamID;
									num1++;
									break;
								}
								else if (enemies[l].Name != RandomizerForEnemy.LIST_BOSS[num7])
								{
									num7++;
								}
								else if (num7 < 9)
								{
									if (choiceB != 1)
									{
										num = random.Next(0, 386);
										enemies[l].ModelName = enemyDatas2[num].ModelName;
										enemies[l].NPCParamID = enemyDatas2[num].NPCParamID;
										enemies[l].ThinkParamID = enemyDatas2[num].ThinkParamID;
										break;
									}
									else
									{
										num = random.Next(0, 6);
										while (true)
										{
											if (enemies[l].ModelName != enemyDatas1[num].ModelName)
											{
												break;
											}
											num = random.Next(0, 6);
										}
										enemies[l].ModelName = enemyDatas1[num].ModelName;
										enemies[l].NPCParamID = enemyDatas1[num].NPCParamID;
										enemies[l].ThinkParamID = enemyDatas1[num].ThinkParamID;
										break;
									}
								}
								else if ((num7 < 9 ? false : num7 < 22))
								{
									if (choiceB != 1)
									{
										num = random.Next(0, enemyDatas2.Count);
										enemies[l].ModelName = enemyDatas2[num].ModelName;
										enemies[l].NPCParamID = enemyDatas2[num].NPCParamID;
										enemies[l].ThinkParamID = enemyDatas2[num].ThinkParamID;
										break;
									}
									else
									{
										num = random.Next(0, 23);
										while (true)
										{
											if (enemies[l].ModelName != enemyDatas1[num].ModelName)
											{
												break;
											}
											num = random.Next(0, 23);
										}
										enemies[l].ModelName = enemyDatas1[num].ModelName;
										enemies[l].NPCParamID = enemyDatas1[num].NPCParamID;
										enemies[l].ThinkParamID = enemyDatas1[num].ThinkParamID;
										break;
									}
								}
								else if (choiceB != 1)
								{
									num = random.Next(0, enemyDatas2.Count);
									enemies[l].ModelName = enemyDatas2[num].ModelName;
									enemies[l].NPCParamID = enemyDatas2[num].NPCParamID;
									enemies[l].ThinkParamID = enemyDatas2[num].ThinkParamID;
									break;
								}
								else
								{
									num = random.Next(0, enemyDatas1.Count);
									while (true)
									{
										if (enemies[l].ModelName != enemyDatas1[num].ModelName)
										{
											break;
										}
										num = random.Next(0, enemyDatas1.Count);
									}
									enemies[l].ModelName = enemyDatas1[num].ModelName;
									enemies[l].NPCParamID = enemyDatas1[num].NPCParamID;
									enemies[l].ThinkParamID = enemyDatas1[num].ThinkParamID;
									break;
								}
							}
							if (enemies[l].ModelName == "c5280")
							{
								EMEVD.Instruction instruction = new EMEVD.Instruction()
								{
									Bank = 2000,
									ID = 6
								};
								byte[] bytes = BitConverter.GetBytes(enemies[l].EventEntityID);
								bytes.CopyTo(numArray, 4);
								instruction.ArgData = numArray;
								instructions.Add(instruction);
							}
							else if (enemies[l].NPCParamID == 502001)
							{
								EMEVD.Instruction instruction1 = new EMEVD.Instruction()
								{
									Bank = 2000,
									ID = 6
								};
								byte[] bytes1 = BitConverter.GetBytes(enemies[l].EventEntityID);
								bytes1.CopyTo(numArray1, 4);
								instruction1.ArgData = numArray1;
								instructions.Add(instruction1);
							}
							else if (enemies[l].NPCParamID == 502002)
							{
								EMEVD.Instruction instruction2 = new EMEVD.Instruction()
								{
									Bank = 2000,
									ID = 6
								};
								byte[] bytes2 = BitConverter.GetBytes(enemies[l].EventEntityID);
								bytes2.CopyTo(numArray2, 4);
								instruction2.ArgData = numArray2;
								instructions.Add(instruction2);
							}
						}
					}
				}
				mSB3.Write(RandomizerForEnemy.LIST_FILE_RANDOM_WRITE[i]);
				eMEVD.Write(RandomizerForEnemy.EVENT_WRITE[i]);
			}
		}

		public class EnemyData
		{
			public int EventEntityID;

			public string EnemyName;

			public int NPCParamID;

			public int ThinkParamID;

			public string ModelName;

			public EnemyData()
			{
			}
		}
	}
}