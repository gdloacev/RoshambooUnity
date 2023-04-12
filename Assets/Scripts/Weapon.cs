using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Collections;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Weapons weapon;
    [SerializeField] private Sprite weaponImage;

    private Image _image;
    private AudioSource _audioSource;

    private void Awake()
    {
        _image = this.gameObject.GetComponent<Image>();
        _image.sprite = weaponImage;
        _audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnClickWeapon() {
        _audioSource.Play();
        EventManager.OnClickWeapon((int)weapon);
    }
}
