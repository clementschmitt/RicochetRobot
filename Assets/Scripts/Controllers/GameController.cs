using System.Collections;
using System.Collections.Generic;
using Assets.ProjectResources.Prefabs.Default;
using Assets.Scripts.Model;
using Assets.Scripts.Helpers;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class GameController : MonoBehaviour
    {

        private static GameController _instance;

        public static GameController Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("Controller isn't instaciated yet");
                    return null;
                }

                return _instance;
            }
        }

        // Use this for initialization
        IEnumerator Start()
        {
            _instance = this;
            GameObject cellPrefab = null;
            yield return StartCoroutine(AssetBundleLoaderHelper.LoadAssetBundleEnumerator(@"file:///D:\Dev\RicochetRobot\AssetBundles\default", CellComponent.AssetName, o => cellPrefab = o));
           
            BoardPart b = DefaultBoards.GetDefaultNorthWestBoardRecto();
            DrawBoard(cellPrefab, b);
            b = DefaultBoards.GetDefaultNorthEastBoardRecto();
            DrawBoard(cellPrefab, b);
            b = DefaultBoards.GetDefaultSouthWestBoardRecto();
            DrawBoard(cellPrefab, b);
            b = DefaultBoards.GetDefaultSouthEastBoardRecto();
            DrawBoard(cellPrefab, b);

            yield break;
        }

        private void DrawBoard(GameObject cellPrefab, BoardPart boardPart)
        {
            int y = 0;
            foreach (Cell[] row in boardPart.Cells)
            {
                int x = 0;
                foreach (Cell cell in row)
                {
                    CellComponent c = null;

                    if (cellPrefab != null)
                        c = GameObjectHelper.Instanciate(cellPrefab, gameObject).GetComponent<CellComponent>();

                    if (c != null)
                    {
                        c.name = "cell_row_" + x + "col_" + y;
                        c.Cell = cell;
                        c.BoardPosition = boardPart.BoardPosition;
                        switch (boardPart.BoardPosition)
                        {
                            case BoardPosition.NorthWest:
                                c.transform.position = new Vector3(-Mathf.Abs(x - 7), 0, Mathf.Abs(y - 7));
                                break;
                            case BoardPosition.NorthEast:
                                c.transform.position = new Vector3(x, 0, Mathf.Abs(y - 7));
                                break;
                            case BoardPosition.SouthWest:
                                c.transform.position = new Vector3(-Mathf.Abs(x - 7), 0, -y);
                                break;
                            case BoardPosition.SouthEast:
                                c.transform.position = new Vector3(x, 0, -y);
                                break;
                        }

                    }
                    x++;
                }
                y++;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
