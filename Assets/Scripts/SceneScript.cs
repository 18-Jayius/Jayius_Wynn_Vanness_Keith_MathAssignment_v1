using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void part1()
    {
        SceneManager.LoadScene("Part1");
    }

    public void part2()
    {
        SceneManager.LoadScene("Part2");
    }

    public void part3()
    {
        SceneManager.LoadScene("Part3");
    }

    public void part4()
    {
        SceneManager.LoadScene("Part4");
    }

    public void part5()
    {
        SceneManager.LoadScene("Part5");
    }

    public void part6()
    {
        SceneManager.LoadScene("Part6");
    }

    public void exit()
    {
        Application.Quit();
    }
    public void returntoscene()
        {
        SceneManager.LoadScene("SampleScene");
        }
}
